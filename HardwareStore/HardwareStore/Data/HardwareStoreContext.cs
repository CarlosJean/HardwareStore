using HardwareStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStore.Data
{
    public class HardwareStoreContext : DbContext {
        public HardwareStoreContext(DbContextOptions<HardwareStoreContext> options) : base(options) {

        }

        public DbSet<Business> Businesses { get; set; }
        public DbSet<Charge> Charges { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UnitOfMeasurement> UnitsOfMeasurement { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Business>().ToTable("Business");
            modelBuilder.Entity<Charge>().ToTable("Charge");
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Item>()
                .ToTable("Item")
                .Property(x => x.Availability)
                .HasDefaultValue(0);
            modelBuilder.Entity<Item>().HasIndex(i => new { i.Name, i.UnitOfMeasurementId}).IsUnique();
            modelBuilder.Entity<Module>().ToTable("Module");
            modelBuilder.Entity<Supplier>().ToTable("Supplier");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<UnitOfMeasurement>().ToTable("UnitOfMeasurement");

        }
    }
}
