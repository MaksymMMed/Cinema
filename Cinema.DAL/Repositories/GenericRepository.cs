using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Reflection;
using Cinema.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Cinema.DAL.Repositories;

public class GenericRepository<TModel, TId>(AppDbContext dbContext) : IGenericRepository<TModel, TId>
    where TModel : class
{
    protected readonly AppDbContext DbContext = dbContext;
    protected readonly DbSet<TModel> DbSet = dbContext.Set<TModel>();

    public virtual Task<List<TModel>> GetAll(Func<IQueryable<TModel>, IIncludableQueryable<TModel, object>>? include = null)
    {
        return (include != null) ? include(DbSet).ToListAsync() : DbSet.ToListAsync();
    }

    public virtual IQueryable<TModel> GetAllAsIQueryable()
    {
        return DbSet;
    }

    public virtual async Task<TModel?> GetFirstFiltered(Expression<Func<TModel, bool>>? filter = null, Func<IQueryable<TModel>, IOrderedQueryable<TModel>>? orderBy = null, Func<IQueryable<TModel>, IIncludableQueryable<TModel, object>>? include = null, bool disableTracking = false)
    {
        var result = GetQuery(filter, orderBy, include, disableTracking);
        return await result.FirstOrDefaultAsync();

    }

    public virtual async Task<TResult?> GetFirstMapped<TResult>(Expression<Func<TModel, TResult>> selector, Expression<Func<TModel, bool>>? filter = null, Func<IQueryable<TModel>, IOrderedQueryable<TModel>>? orderBy = null, Func<IQueryable<TModel>, IIncludableQueryable<TModel, object>>? include = null, bool disableTracking = false)
    {
        var query = GetQuery(filter, orderBy, include, disableTracking);
        return await query.Select(selector).FirstOrDefaultAsync();
    }

    public virtual Task<List<TModel>> GetAllFiltered(Expression<Func<TModel, bool>>? filter = null, Func<IQueryable<TModel>, IOrderedQueryable<TModel>>? orderBy = null, Func<IQueryable<TModel>, IIncludableQueryable<TModel, object>>? include = null, bool disableTracking = false)
    {
        IQueryable<TModel> query = DbSet;
        if (disableTracking)
        {
            query = query.AsNoTracking();
        }
        if (filter != null)
        {
            query = query.Where(filter);
        }
        if (include != null)
        {
            query = include(query);
        }
        if (orderBy != null)
        {
            query = orderBy(query);
        }
        return query.ToListAsync();
    }

    public virtual async Task<List<TResult>> GetAllMapped<TResult>(
        Expression<Func<TModel, TResult>> selector,
        Expression<Func<TModel, bool>>? filter = null,
        Func<IQueryable<TModel>, IOrderedQueryable<TModel>>? orderBy = null,
        Func<IQueryable<TModel>, IIncludableQueryable<TModel, object>>? include = null,
        bool disableTracking = false)
    {
        IQueryable<TModel> query = GetQuery(filter, orderBy, include, disableTracking);
        return await query.Select(selector).ToListAsync();
    }

    protected PropertyInfo GetPrimaryKeyProperty()
    {
        return typeof(TModel)
            .GetProperties()
            .FirstOrDefault(prop => Attribute.IsDefined(prop, typeof(KeyAttribute)))!;
    }

    public virtual async Task<TModel?> GetById(TId id, bool disableTracking = false)
    {
        var primaryKeyProperty = GetPrimaryKeyProperty();

        var parameter = Expression.Parameter(typeof(TModel), "entity");

        var equalExpression = Expression.Equal(
            Expression.Property(parameter, primaryKeyProperty),
            Expression.Constant(id)
        );

        var lambda = Expression.Lambda<Func<TModel, bool>>(equalExpression, parameter);

        var entity = await GetFirstFiltered(lambda, disableTracking: disableTracking);

        return entity;
    }

    public virtual Task<TModel?> GetByIdWithInclude(
        TId id,
        Func<IQueryable<TModel>, IIncludableQueryable<TModel, object>>? include = null, 
        bool disableTracking = false)
    {
        var primaryKeyProperty = GetPrimaryKeyProperty();

        var parameter = Expression.Parameter(typeof(TModel), "entity");

        var equalExpression = Expression.Equal(
            Expression.Property(parameter, primaryKeyProperty),
            Expression.Constant(id)
        );

        var lambda = Expression.Lambda<Func<TModel, bool>>(equalExpression, parameter);

        IQueryable<TModel> query = GetQuery(lambda, disableTracking: disableTracking);
        if (include != null)
        {
            query = include(query);
        }
        return query.SingleOrDefaultAsync();
    }

    public virtual AppDbContext GetContext()
    {
        return DbContext;
    }

    public virtual async Task Add(TModel entity)
    {
        await DbSet.AddAsync(entity);
        await DbContext.SaveChangesAsync();
    }

    public virtual async Task AddRange(IEnumerable<TModel> entities)
    {
        await DbSet.AddRangeAsync(entities);
        await DbContext.SaveChangesAsync();
    }

    public virtual async Task<TModel> Update(TModel entityToUpdate)
    {
        var primaryKeyProperty = GetPrimaryKeyProperty();

        var existingEntity = await DbContext.Set<TModel>().FindAsync(primaryKeyProperty.GetValue(entityToUpdate));
        if (existingEntity != null)
        {
            DbContext.Entry(existingEntity).State = EntityState.Detached;
        }
        DbContext.Update(entityToUpdate);
        await DbContext.SaveChangesAsync();
        return entityToUpdate;
    }

    public virtual async Task<IEnumerable<TModel>> UpdateRange(ICollection<TModel> entitiesToUpdate, string[]? excludeProperties = null)
    {
        DbSet.AttachRange(entitiesToUpdate);
        foreach (var entity in entitiesToUpdate)
        {
            var entry = DbContext.Entry(entity);
            entry.State = EntityState.Modified;

            if (excludeProperties == null) continue;
                
            foreach (var property in excludeProperties)
            {
                entry.Property(property).IsModified = false;
            }
        }

        await DbContext.SaveChangesAsync();
        return entitiesToUpdate;
    }

    public virtual async Task Delete(TModel entityToDelete)
    {
        if (DbContext.Entry(entityToDelete).State == EntityState.Detached)
        {
            DbContext.Attach(entityToDelete);
        }
        DbContext.Remove(entityToDelete);
        await DbContext.SaveChangesAsync();
    }

    public virtual async Task DeleteRange(IEnumerable<TModel> entitiesToDelete)
    {
        DbSet.RemoveRange(entitiesToDelete);
        await DbContext.SaveChangesAsync();
    }

    public virtual Task<bool> AnyAsync(Expression<Func<TModel, bool>> predicate)
    {
        return DbSet.AnyAsync(predicate);
    }

    public Task LoadReference<TProperty>(TModel entity, Expression<Func<TModel, TProperty>> include)
        where TProperty : class
    {
        return DbContext.Entry(entity).Reference(include!).LoadAsync();
    }

    public Task LoadCollection<TProperty>(TModel entity, Expression<Func<TModel, IEnumerable<TProperty>>> include)
        where TProperty : class
    {
        return DbContext.Entry(entity).Collection(include).LoadAsync();
    }

    public virtual async Task<bool> IsExistsAsync(Expression<Func<TModel, bool>> predicate)
    {
        return await DbSet.FirstOrDefaultAsync(predicate) != null;
    }

    public virtual IQueryable<TModel> GetQuery(Expression<Func<TModel, bool>>? filter = null, Func<IQueryable<TModel>, IOrderedQueryable<TModel>>? orderBy = null, Func<IQueryable<TModel>, IIncludableQueryable<TModel, object>>? include = null, bool disableTracking = false)
    {
        IQueryable<TModel> query = DbSet;
        if (disableTracking)
        {
            query = query.AsNoTracking();
        }
        if (filter != null)
        {
            query = query.Where(filter);
        }
        if (include != null)
        {
            query = include(query);
        }
        if (orderBy != null)
        {
            query = orderBy(query);
        }
        return query;
    }
}