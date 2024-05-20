using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.DAL.Configurations;

public class InvoicesConfiguration : IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Amount)
            .HasPrecision(8, 2);

        // Relations
        builder.HasOne(e => e.User)
            .WithMany()
            .HasForeignKey(g => g.UserId)
            .HasConstraintName("UserInvoiceFK");

        //Seeding
        builder.HasData(Seeding.DataSeed.Invoices);
    }
}