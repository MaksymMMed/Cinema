using Cinema.DAL.Entities;

namespace Cinema.BLL.Filtering.Invoices;

public class InvoicesFilteringModel : FilteringModel<Invoice>, IFilter<Invoice>
{

    public IQueryable<Invoice> Filter(IQueryable<Invoice> source)
    {
        return source;
    }
}