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
                    ManuName = "FeverMed",
                    ManuCountry = "China",
                    ManuEmail = "fevermed@gmail.com",
                    ManuContact = "12345678",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Manufacturer
                {
                    Id = 2,
                    ManuName = "AntiBio",
                    ManuCountry = "Germany",
                    ManuEmail = "biomed@gmail.com",
                    ManuContact = "87654321",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );
        }
    }
}