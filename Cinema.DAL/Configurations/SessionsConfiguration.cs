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
            .WithMany()
            .HasForeignKey(e => e.HallId);
        
        builder.HasOne(e => e.Movie)
            .WithMany()
            .HasForeignKey(e => e.MovieId);

        //Seeding
        builder.HasData(Seeding.DataSeed.Sessions);

    }
}