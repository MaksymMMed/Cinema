using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.DAL.Configurations;

public class MoviesConfiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(e => e.Description)
            .IsRequired()
            .HasMaxLength(1000);

        builder.Property(e => e.AgeRestriction)
            .HasMaxLength(10);

        // Relations
        builder.HasOne(e => e.Director)
          .WithMany(e=>e.Movies)
          .HasForeignKey(e => e.DirectorId)
          .HasConstraintName("MovieDirectorFK");

        builder.HasOne(e => e.ImageSet)
            .WithOne(e => e.Movie)
            .HasForeignKey<MovieImageSet>(e => e.MovieId)
            .HasConstraintName("MovieImageSetFK");

        builder.HasMany(e => e.MovieGenres)
            .WithOne(e => e.Movie)
            .HasForeignKey(e => e.MovieId)
            .HasConstraintName("MovieGenreFK"); 

        builder.HasMany(e => e.MovieActors)
            .WithOne(e => e.Movie)
            .HasForeignKey(e => e.MovieId)
            .HasConstraintName("MovieActorFK");

        builder.HasMany(e => e.MovieReviews)    
            .WithOne(e => e.Movie)
            .HasForeignKey(e => e.MovieId)
            .HasConstraintName("MovieReviewFK");

        builder.HasMany(e => e.Sessions)
            .WithOne(e => e.Movie)
            .HasForeignKey(e => e.MovieId)
            .HasConstraintName("MovieSessionFK");

        //Seeding
        builder.HasData(Seeding.DataSeed.Movies);
    }
}