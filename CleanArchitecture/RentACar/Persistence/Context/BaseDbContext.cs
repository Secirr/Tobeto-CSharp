﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Persistence.Context
{
    public class BaseDbContext:DbContext
	{

        public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options)
        {

        }

        //public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        //{
        //    Configuration = configuration; // IConfiguration injection
        //}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=RentACarLessonConnectionString;User Id=SA;Password=reallyStrongPwd123;TrustServerCertificate =True");
        }

        //protected IConfiguration Configuration { get; set; }
        //public DbSet<Brand> Brands { get; set; }
    }
}

