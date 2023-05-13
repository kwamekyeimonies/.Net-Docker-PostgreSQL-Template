using Microsoft.EntityFrameworkCore;
using Demo.Microservices.Infrastructure.Model;

namespace Demo.Microservices.Infrastructure.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        public DbSet<Driver> Drivers {get;set;}
    }
}