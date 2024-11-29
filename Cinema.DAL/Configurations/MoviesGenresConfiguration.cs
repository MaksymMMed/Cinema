using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.DAL.Configurations;

public class MoviesGenresConfiguration : IEntityTypeConfiguration<MovieGenre>
{
    public void Configure(EntityTypeBuilder<MovieGenre> builder)
    {
        builder.HasKey(sc => new { sc.MovieId, sc.GenreId });

        // Relations
        builder.HasOne(e => e.Movie)
            .WithMany(e => e.MovieGenres)
            .HasForeignKey(g => g.MovieId)
            .HasConstraintName("MovieGenreFK");
        
        builder.HasOne(e => e.Genre)
            .WithMany(e => e.MoviesGenre)   
            .HasForeignKey(g => g.GenreId)
            .HasConstraintName("GenreMovieFK");

        //Seeding
        builder.HasData(Seeding.DataSeed.MoviesGenres);
    }
}