using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.DAL.Configurations;

public class InvoicesConfiguration : IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        builder.HasKey(e => e.Id);

        // Relations
        builder.HasOne(e => e.User)
            .WithMany()
            .HasForeignKey(g => g.UserId);
        
        builder.HasOne(e => e.Ticket)
            .WithMany()
            .HasForeignKey(g => g.TicketId);
        
        //Seeding
        
    }
}