using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.DAL.Configurations;

public class DirectorsConfiguration : IEntityTypeConfiguration<Director>
{
    public void Configure(EntityTypeBuilder<Director> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(35);

        // Relations
        builder.HasMany(e => e.Movies)
            .WithOne(e => e.Director)
            .HasForeignKey(g => g.DirectorId)
            .HasConstraintName("MovieDirectorFK");

        //Seeding
        builder.HasData(Seeding.DataSeed.Directors);
    }
}