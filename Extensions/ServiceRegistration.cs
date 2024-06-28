using Microsoft.EntityFrameworkCore;
using taxi_app_api.DatabaseContext;
using taxi_app_api.Models;
using taxi_app_api.Services;
using taxi_app_api.Services.Contracts;

namespace taxi_app_api.Extensions
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddRegistredServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TaxiAppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("TaxiAppConnectionString"));
            });

            services.AddScoped<ICarOwner, CarOwnerService>(); 
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ICarService, CarService>();

            return services; 
        }

    }
}
