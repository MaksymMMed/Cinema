using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.DAL.Configurations;

public class SessionsConfiguration : IEntityTypeConfiguration<Session>
{
    public void Configure(EntityTypeBuilder<Session> builder)
    {
        builder.HasKey(e => e.Id);

        // Relations
        builder.HasOne(e => e.Hall)
            .WithMany(e => e.Sessions)
            .HasForeignKey(e => e.HallId)
            .HasConstraintName("SessionHallFK");

        builder.HasOne(e => e.Movie)
            .WithMany(e => e.Sessions)
            .HasForeignKey(e => e.MovieId)
            .HasConstraintName("MovieSessionFK");

        builder.HasMany(e => e.Tickets)
            .WithOne(e => e.Session)
            .HasForeignKey(e => e.SessionId)
            .HasConstraintName("TicketSessionFK");

        //Seeding
        builder.HasData(Seeding.DataSeed.Sessions);

    }
}