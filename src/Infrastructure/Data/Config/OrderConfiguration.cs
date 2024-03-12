using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Config
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            // sahiplik (iki yönlü iliski)
            builder.OwnsOne(x => x.ShipToAdress, ba =>
            {
                ba.WithOwner();

                ba.Property(x => x.Street)
                    .HasMaxLength(180);

                ba.Property(x => x.City)
                    .HasMaxLength(100);

                ba.Property(x => x.State)
                    .HasMaxLength(60);

                ba.Property(x => x.Country)
                    .HasMaxLength(90);

                ba.Property(x => x.ZipCode)
                    .HasMaxLength(18);
            });
        }
    }
}
