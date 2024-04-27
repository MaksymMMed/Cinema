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
            .WithMany()
            .HasForeignKey(e => e.SessionId);
        
        builder.HasOne(e => e.Hall)
            .WithMany()
            .HasForeignKey(e => e.HallId);
        
        builder.HasOne(e => e.User)
            .WithMany()
            .HasForeignKey(g => g.UserId);

        //Seeding

    }
}