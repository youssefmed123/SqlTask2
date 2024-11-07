using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P01_SalesDatabase.Models;

namespace P01_SalesDatabase.Data
{
    internal class ApplicationDbContext : DbContext

    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Sales.Task;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
               .Property(p => p.Name)
               .HasMaxLength(50)
               .IsUnicode(true);

            modelBuilder.Entity<Customer>()
                .Property(c => c.Name)
                .HasMaxLength(100)
                .IsUnicode(true);

            modelBuilder.Entity<Customer>()
                .Property(c => c.Email)
                .HasMaxLength(80)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
               .Property(c => c.CreditCardNumber)
               .IsUnicode(false);

            modelBuilder.Entity<Store>()
               .Property(s => s.Name)
               .HasMaxLength(80)
               .IsUnicode(true);
        }
    }
}
