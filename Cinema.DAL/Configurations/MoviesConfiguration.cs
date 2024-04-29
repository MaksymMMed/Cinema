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
          .WithMany()
          .HasForeignKey(e => e.DirectorId);

        builder.HasOne(e => e.ImageSet)
            .WithOne(e => e.Movie)
            .HasForeignKey<MovieImageSet>(e => e.MovieId);

        //Seeding
        builder.HasData(Seeding.DataSeed.Movies);
    }
}