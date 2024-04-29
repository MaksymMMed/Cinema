using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.DAL.Configurations;

public class GenresConfiguration : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(20);

        // Relations
        builder.HasMany(e => e.MoviesGenre)
            .WithOne(e => e.Genre)
            .HasForeignKey(e => e.GenreId)
            .HasConstraintName("GenreMovieFK");

        //Seeding
        builder.HasData(Seeding.DataSeed.Genres);
    }
}