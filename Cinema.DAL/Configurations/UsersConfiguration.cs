using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.DAL.Configurations;

public class UsersConfiguration : IEntityTypeConfiguration<AspNetUser>
{
    public void Configure(EntityTypeBuilder<AspNetUser> builder)
    {
        builder.HasKey(e => e.Id);

        // Relations
        builder.HasMany(x => x.Invoices)
            .WithOne(x => x.User)
            .OnDelete(DeleteBehavior.Restrict)
            .HasForeignKey(x => x.UserId)
            .HasConstraintName("UserInvoiceFK");

        builder.HasMany(x => x.Tickets)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.UserId)
            .HasConstraintName("TicketUserFK");

        builder.HasMany(x => x.Reviews)
            .WithOne(x => x.CreatedBy)
            .HasForeignKey(x=> x.CreatedById)
            .HasConstraintName("UserReviewFK");


        //Seeding
        builder.HasData(Seeding.DataSeed.Users);

    }
}