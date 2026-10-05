using DEALERSHIP_MANAGEMENT_SYSTEM.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DEALERSHIP_MANAGEMENT_SYSTEM.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerProfile> CustomersProfile { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Category>().HasIndex(a => a.CategoryName).IsUnique();
            modelBuilder.Entity<Vehicle>().HasIndex(a => a.VIN).IsUnique();
            modelBuilder.Entity<Customer>().HasIndex(a => a.Email).IsUnique();
            modelBuilder.Entity<Customer>().HasIndex(a => a.DriverLicenseNumber).IsUnique();
            modelBuilder.Entity<Employee>().HasIndex(a => a.Email).IsUnique();

        
            modelBuilder.Entity<Vehicle>().Property(a => a.Price).HasPrecision(12, 2);
            modelBuilder.Entity<Sale>().Property(a => a.SalePrice).HasPrecision(12, 2);
            modelBuilder.Entity<Vehicle>().Property(a => a.Status).HasDefaultValue("Available");

           
            modelBuilder.Entity<Category>()
                .HasMany(e => e.vehicles)
                .WithOne(e => e.category)
                .HasForeignKey(a => a.CategoryId) 
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.sales)
                .WithOne(e => e.customer)
                .HasForeignKey(a => a.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.sales)
                .WithOne(e => e.employee)
                .HasForeignKey(a => a.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vehicle>()
                .HasOne(a => a.Sale)
                .WithOne(a => a.vehicle)
                .HasForeignKey<Sale>(a => a.VehicleId); 

            modelBuilder.Entity<CustomerProfile>()
                .HasOne(a => a.Customer)
                .WithOne(a => a.CustomerProfile)
                .HasForeignKey<CustomerProfile>(cp => cp.CustomerId);

            
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Sedan", Description = "Comfortable passenger cars" },
                new Category { CategoryId = 2, CategoryName = "SUV", Description = "Sport utility vehicles" },
                new Category { CategoryId = 3, CategoryName = "Hatchback", Description = "Compact practical cars" }
            );

            modelBuilder.Entity<Vehicle>().HasData(new Vehicle
            {
                VehicleId = 1,
                Make = "Toyota",
                Model = "Corolla",
                Color = "White",
                Price = 650000,
                Mileage = 12000,
                VIN = "VIN00000000000001",
                FuelType = "Petrol",
                Transmission = "Automatic",
                Status = "Sold",
                CategoryId = 1 
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId = 1,
                FullName = "Ahmed Hassan",
                Email = "ahmedhassan@gmail.com",
                Phone = "01010000001",
                DriverLicenseNumber = "DL100001"
            });

            modelBuilder.Entity<CustomerProfile>().HasData(new CustomerProfile
            {
                CustomerProfileId = 1,
                CustomerId = 1,
                Address = "12 Nile St.",
                City = "Cairo",
                Nationality = "Egyptian",
                DateOfBirth = new DateTime(1995, 4, 15) 
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FullName = "Mostafa Nabil",
                Position = "Sales Manager",
                Email = "mostafanabil@autodrive.com",
                Phone = "01020000001",
                HireDate = new DateTime(2021, 1, 10) 
            });

            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                SaleId = 1,
                SaleDate = new DateTime(2026, 8, 15), 
                SalePrice = 1750000,
                PaymentMethod = "Bank Transfer",
                Notes = "Completed sale",
                CustomerId = 1,
                EmployeeId = 1,
                VehicleId = 1
            });
        }
    }
}