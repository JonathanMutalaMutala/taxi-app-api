using Microsoft.EntityFrameworkCore;
using taxi_app_api.Models;

namespace taxi_app_api.DatabaseContext
{
    public class TaxiAppDbContext : DbContext
    {
        private readonly DbContextOptions<TaxiAppDbContext> options;

        public TaxiAppDbContext(DbContextOptions<TaxiAppDbContext> options) : base(options)
        {
            this.options = options;
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarOwner> CarOwners { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override  void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TaxiAppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
