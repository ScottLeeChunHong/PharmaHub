using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharmaHub.Shared.Domain;

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
                    Country = "China",
                    Email = "fevermed@gmail.com",
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
                    Country = "Germany",
                    Email = "biomed@gmail.com",
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