using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.DAL.Configurations;

public class TicketsConfiguration : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder.HasKey(e => e.Id);
        
        // The constraint to avoid tickets collision
        builder.HasIndex(t => new { t.SessionId, t.RowIndex, t.SeatIndex })
            .IsUnique();

        // Relations
        builder.HasOne(e => e.Session)
            .WithMany(e => e.Tickets)
            .OnDelete(DeleteBehavior.Restrict)
            .HasForeignKey(e => e.SessionId)
            .HasConstraintName("TicketSessionFK");

        builder.HasOne(e => e.Invoice)
            .WithMany(e => e.Tickets)
            .HasConstraintName("InvoiceTicketsFK");

        //Seeding
        builder.HasData(Seeding.DataSeed.Tickets);

    }
}