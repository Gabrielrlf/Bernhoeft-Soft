using Bernhoeft.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernhoeft.Infra.Context
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
       => options.UseSqlite("Data Source=Bernhoeft.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>()
                .HasData(
                    new Category()
                    {
                        Id = 1,
                        PropertyName = "Humano",
                        Situation = true,
                        CreationDate = DateTime.Now,
                        LastUpdate = DateTime.Now
                    }
                );

            modelBuilder.Entity<Product>()
                .HasData(
                    new Product()
                    {
                        Id = 1,
                        PropertyName = "Gabriel Fonseca",
                        Situation = true,
                        Description = "Produto 1",
                        Price = 10.50m,
                        CreationDate = DateTime.Now,
                        LastUpdate = DateTime.Now
                    }
                );
        }
    }
}
