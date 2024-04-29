using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.DAL.Configurations;

public class UsersConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(e => e.Id);

        // Relations
        builder.HasMany(e => e.Tickets)
            .WithOne()
            .HasForeignKey(g => g.UserId);

        //Seeding
        builder.HasData(Seeding.DataSeed.Users);

    }
}