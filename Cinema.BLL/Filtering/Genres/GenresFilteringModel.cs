using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cinema.BLL.Filtering.Genres
{
    public class GenresFilteringModel : FilteringModel<Genre>, IFilter<Genre>
    {
        public string? Name { get; set; }

        public IQueryable<Genre> Filter(IQueryable<Genre> source)
        {
            if (!string.IsNullOrEmpty(Name))
                source = source.Where(v => EF.Functions.Like(v.Name, $"%{Name}%"));

            return source;
        }
    }
}
