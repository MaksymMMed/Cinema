using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.DAL.Configurations;

public class ActorsConfiguration : IEntityTypeConfiguration<Actor>
{
    public void Configure(EntityTypeBuilder<Actor> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(35);

        // Relations
        builder.HasMany(e => e.ActorMovies)
            .WithOne(e => e.Actor)
            .HasForeignKey(g => g.ActorId)
            .HasConstraintName("ActorMovieFK");

        //Seeding
        builder.HasData(Seeding.DataSeed.Actors);
        
    }
}