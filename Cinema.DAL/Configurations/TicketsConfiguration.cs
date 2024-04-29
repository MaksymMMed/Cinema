using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.DAL.Configurations;

public class TicketsConfiguration : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder.HasKey(e => e.Id);

        // Relations
        builder.HasOne(e => e.Session)
            .WithMany(e => e.Tickets)
            .OnDelete(DeleteBehavior.Restrict)
            .HasForeignKey(e => e.SessionId)
            .HasConstraintName("TicketSessionFK");
        
        builder.HasOne(e => e.Hall)
            .WithMany(e => e.Tickets)
            .HasForeignKey(e => e.HallId)
            .HasConstraintName("TicketHallFK");
        
        builder.HasOne(e => e.User)
            .WithMany(e => e.Tickets)
            .HasForeignKey(g => g.UserId)
            .HasConstraintName("TicketUserFK");

        builder.HasOne(e => e.Invoice)
            .WithOne(e => e.Ticket)
            .HasConstraintName("TicketInvoiceFK");

        //Seeding
        builder.HasData(Seeding.DataSeed.Tickets);

    }
}