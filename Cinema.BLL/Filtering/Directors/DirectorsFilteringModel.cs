using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cinema.BLL.Filtering.Directors
{
    public class DirectorsFilteringModel : FilteringModel<Director>, IFilter<Director>
    {
        public string? Name {  get; set; }
        public IQueryable<Director> Filter(IQueryable<Director> source)
        {
            if (!string.IsNullOrEmpty(Name))
                source = source.Where(v => EF.Functions.Like(v.Name, $"%{Name}%"));

            return source;
        }
    }
}
