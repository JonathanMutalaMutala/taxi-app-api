using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using taxi_app_api.Models;

namespace taxi_app_api.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasData(new Car
            {
                Id = 1,
                TypeName = "Toyota",
                Color = "Black",
                LicensePlate = "QQQ 321",
                NumberOfPerson = 4,
                IsActive = true,
            });
        }
    }
}
