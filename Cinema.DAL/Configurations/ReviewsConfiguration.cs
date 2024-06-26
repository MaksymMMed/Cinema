using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.DAL.Configurations;

public class ReviewsConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Comment)
            .HasMaxLength(500);

        // Relations
        builder.HasOne(e => e.CreatedBy)
            .WithMany(e => e.Reviews)
            .HasForeignKey(e => e.CreatedById)
            .HasConstraintName("UserReviewFK");

        
        builder.HasOne(e => e.Movie)
            .WithMany(e => e.MovieReviews)
            .HasForeignKey(e => e.MovieId)
            .HasConstraintName("MovieReviewFK");

        //Seeding
        builder.HasData(Seeding.DataSeed.Reviews);
    }
}