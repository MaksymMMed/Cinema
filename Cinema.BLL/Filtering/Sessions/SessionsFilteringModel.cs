﻿using Cinema.DAL.Entities;

namespace Cinema.BLL.Filtering.Sessions;

public class SessionsFilteringModel : FilteringModel<Session>, IFilter<Session>
{
    public DateTime? FromDate { get; set; }
    public DateTime? ToDate { get; set; }
    public decimal? FromBasePrice { get; set; }
    public decimal? ToBasePrice { get; set; }
    public Guid? HallId { get; set; }
    public Guid? MovieId { get; set; }

    public IQueryable<Session> Filter(IQueryable<Session> source)
    {
        if (FromDate.HasValue)
            source = source.Where(v => v.DateUtc >= FromDate.Value);

        if (ToDate.HasValue)
            source = source.Where(v => v.DateUtc <= ToDate.Value);

        if (FromBasePrice.HasValue)
            source = source.Where(v => v.BasePrice >= FromBasePrice.Value);

        if (ToBasePrice.HasValue)
            source = source.Where(v => v.BasePrice <= ToBasePrice.Value);

        if (HallId.HasValue)
            source = source.Where(v => v.HallId == HallId.Value);

        if (MovieId.HasValue)
            source = source.Where(v => v.MovieId == MovieId.Value);

        return source;
    }
}
