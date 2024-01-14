using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharmaHub.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaHub.Server.Configurations.Entities
{
    public class ManufacturerSeedConfiguration : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder.HasData(
                new Manufacturer
                {
                    Id = 1,
                    Name = "FeverMed",
                    Email = "fevermed@gmail.com",
                    Country = "China",
                    Contact = "12345678",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Manufacturer
                {
                    Id = 2,
                    Name = "AntiBio",
                    Email = "biomed@gmail.com",
                    Country = "Germany",
                    Contact = "87654321",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );
        }
    }
}