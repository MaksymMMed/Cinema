using Cinema.DAL.Entities;
using Cinema.DAL.Utilities.Interfaces.TrackChanges;

namespace Cinema.BLL.Extensions;

public static class CreatedByExtension
{
    public static void RegisterCreation(this ICreatedBy createdBy, User user)
    {
        createdBy.CreatedById = user.Id;
        createdBy.CreatedByName = user.UserName ?? "";
        createdBy.CreatedOnUtc = DateTime.UtcNow;
    }
}