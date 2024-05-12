using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BLL.Filtering.Actors
{
    public class ActorsFilteringModel : FilteringModel<Actor>, IFilter<Actor>
    {
        public string? Name { get; set; }
        public IQueryable<Actor> Filter(IQueryable<Actor> source)
        {
            if (!string.IsNullOrEmpty(Name))
                source = source.Where(v => EF.Functions.Like(v.Name, $"%{Name}%"));

            return source;
        }
    }
}
