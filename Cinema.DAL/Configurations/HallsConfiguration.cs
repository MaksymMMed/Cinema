using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.DAL.Configurations;

public class HallsConfiguration : IEntityTypeConfiguration<Hall>
{
    public void Configure(EntityTypeBuilder<Hall> builder)
    {
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(20);

        // Relations
        builder.HasMany(e => e.Sessions)
            .WithOne(e => e.Hall)
            .HasForeignKey(g => g.HallId)
            .HasConstraintName("SessionHallFK");

        //Seeding
        builder.HasData(Seeding.DataSeed.Halls);

    }
}