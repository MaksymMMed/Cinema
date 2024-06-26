using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.DAL.Configurations;

public class MoviesImageSetsConfiguration : IEntityTypeConfiguration<MovieImageSet>
{
    public void Configure(EntityTypeBuilder<MovieImageSet> builder)
    {
        builder.HasKey(e => e.MovieId);

        // Relations
        builder.HasOne(e => e.Movie)
            .WithOne(e => e.ImageSet)
            .HasConstraintName("MovieImageSetFK");

        //Seeding
        builder.HasData(Seeding.DataSeed.MovieImageSets);
    }
}