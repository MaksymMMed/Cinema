namespace Cinema.DAL.Utilities.Interfaces.TrackChanges
{
    public interface ICreatedBy : ICreatedDate
    {
        string CreatedByName { get; set; }
        Guid CreatedById { get; set; }
    }
}
