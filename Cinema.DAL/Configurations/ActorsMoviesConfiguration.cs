using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.DAL.Configurations;

public class ActorsMoviesConfiguration : IEntityTypeConfiguration<ActorMovie>
{
    public void Configure(EntityTypeBuilder<ActorMovie> builder)
    {
        builder.HasKey(sc => new { sc.ActorId, sc.MovieId });

        // Relations
        builder.HasOne(e => e.Actor)
            .WithMany(e => e.ActorMovies)
            .HasForeignKey(g => g.ActorId);
        
        builder.HasOne(e => e.Movie)
            .WithMany(e => e.MovieActors)
            .HasForeignKey(g => g.MovieId);
        
        //Seeding
        
    }
}