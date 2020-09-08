using CityGasWebApi.Models.Archives;
using Microsoft.EntityFrameworkCore;

namespace CityGasWebApi.Models
{
    public class CityGasContext : DbContext
    {
        public CityGasContext(DbContextOptions<CityGasContext> options) : base(options)
        {

        }
        public DbSet<Device> Device { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

