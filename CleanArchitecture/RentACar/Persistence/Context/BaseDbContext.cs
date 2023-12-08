using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Persistence.Context
{
    public class BaseDbContext:DbContext
	{

        public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration; // IConfiguration injection
            Database.EnsureCreated(); //veri tabanını otomatik oluşturur.
        }

        protected IConfiguration Configuration { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}

