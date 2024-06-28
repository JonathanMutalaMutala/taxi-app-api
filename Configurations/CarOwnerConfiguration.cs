using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using taxi_app_api.Models;

namespace taxi_app_api.Configurations
{
    public class CarOwnerConfiguration : IEntityTypeConfiguration<CarOwner>
    {
        public void Configure(EntityTypeBuilder<CarOwner> builder)
        {
            builder.HasData(new CarOwner
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = DateTime.Now.AddYears(-30),
                PhoneNumber = "1234567890",
                Email = "johndoe@gmail.com",
                Address = "3930 Masson",
                IsActive = true,
                LicenseId = "1234567890",
                CarId = 1
            }); 
        }
    }
}
