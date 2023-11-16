using System;
using System.Net.Sockets;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{

	//Context : Db tabloları ile proje classlarını bağlamak.

	public class NorthwindContext : DbContext
	{


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=NORTHWIND;User Id=SA;Password=reallyStrongPwd123;TrustServerCertificate =True");

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

    }
}

