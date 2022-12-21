using Bernhoeft.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernhoeft.Infra.Context
{
    class ProductDbContext : DbContext
    {
        public DbSet<Product> products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
       => options.UseSqlite("Data Source=Bernhoeft.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(
                    new Product()
                    {
                        Id = 1,
                        Name = new Name()
                        {
                            FirstName = "Gabriel",
                            LastName = "Fonseca"
                        },
                        Situation = new Situation()
                        {
                            Active = true
                        },
                        Description = "Produto 1",
                        Price = 10.50m,
                        CreationDate = DateTime.Now,
                        LastUpdate = DateTime.Now
                    }
                );
        }
    }
}
