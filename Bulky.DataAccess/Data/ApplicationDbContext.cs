using DepiEC.Models;
using DepiEC.Models.ViewModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DepiEC.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Comedy", DisplayOrder = 3 },
                new Category { Id = 4, Name = "History", DisplayOrder = 4 }
                );

            modelBuilder.Entity<Company>().HasData(
              new Company
              {
                  Id = 1,
                  Name = "OPPO",
                  StreetAddress = "123 Tech St",
                  City = "Tech City",
                  PostalCode = "12121",
                  State = "IL",
                  PhoneNumber = "6669990000"
              },
              new Company
              {
                  Id = 2,
                  Name = "I Phone",
                  StreetAddress = "999 Vid St",
                  City = "Vid City",
                  PostalCode = "66666",
                  State = "IL",
                  PhoneNumber = "7779990000"
              },
              new Company
              {
                  Id = 3,
                  Name = "Dell",
                  StreetAddress = "999 Main St",
                  City = "Lala land",
                  PostalCode = "99999",
                  State = "NY",
                  PhoneNumber = "1113335555"
              }
            );

            modelBuilder.Entity<Product>().HasData(

                // Mobiles
                new Product
                {
                    Id = 1,
                    Title = "Oppo A5",
                    CompanyName = "Oppo",
                    Description = "A budget-friendly smartphone with dual cameras and a large battery.",
                    SerilNo = "SWD9999001",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "Samsung Galaxy S22",
                    CompanyName = "Samsung",
                    Description = "Flagship smartphone with high-end camera and AMOLED display.",
                    SerilNo = "SWD9999002",
                    ListPrice = 799,
                    Price = 750,
                    Price50 = 730,
                    Price100 = 710,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "iPhone 14",
                    CompanyName = "Apple",
                    Description = "Apple's latest iPhone with A15 Bionic chip and improved battery life.",
                    SerilNo = "SWD9999003",
                    ListPrice = 999,
                    Price = 950,
                    Price50 = 920,
                    Price100 = 890,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 4,
                    Title = "Xiaomi Redmi Note 12",
                    CompanyName = "Xiaomi",
                    Description = "Mid-range smartphone with 120Hz AMOLED display and fast charging.",
                    SerilNo = "SWD9999004",
                    ListPrice = 299,
                    Price = 270,
                    Price50 = 260,
                    Price100 = 250,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 5,
                    Title = "OnePlus Nord CE 3",
                    CompanyName = "OnePlus",
                    Description = "Affordable OnePlus phone with 5G support and clean OxygenOS.",
                    SerilNo = "SWD9999005",
                    ListPrice = 399,
                    Price = 380,
                    Price50 = 370,
                    Price100 = 360,
                    CategoryId = 1
                },

                // Laptops
                new Product
                {
                    Id = 6,
                    Title = "Dell Inspiron 15",
                    CompanyName = "Dell",
                    Description = "Reliable everyday laptop with Intel i5 processor and 8GB RAM.",
                    SerilNo = "LTP9999001",
                    ListPrice = 999,
                    Price = 950,
                    Price50 = 930,
                    Price100 = 900,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 7,
                    Title = "HP Pavilion 14",
                    CompanyName = "HP",
                    Description = "Slim and light laptop perfect for students and professionals.",
                    SerilNo = "LTP9999002",
                    ListPrice = 899,
                    Price = 850,
                    Price50 = 830,
                    Price100 = 800,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 8,
                    Title = "Lenovo ThinkPad E14",
                    CompanyName = "Lenovo",
                    Description = "Business-class laptop with solid build and great keyboard.",
                    SerilNo = "LTP9999003",
                    ListPrice = 849,
                    Price = 820,
                    Price50 = 800,
                    Price100 = 780,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 9,
                    Title = "MacBook Air M2",
                    CompanyName = "Apple",
                    Description = "Ultra-portable MacBook with M2 chip and all-day battery life.",
                    SerilNo = "LTP9999004",
                    ListPrice = 1199,
                    Price = 1149,
                    Price50 = 1120,
                    Price100 = 1090,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 10,
                    Title = "Asus ROG Zephyrus G14",
                    CompanyName = "Asus",
                    Description = "Powerful gaming laptop with Ryzen processor and RTX graphics.",
                    SerilNo = "LTP9999005",
                    ListPrice = 1399,
                    Price = 1350,
                    Price50 = 1320,
                    Price100 = 1290,
                    CategoryId = 2
                }

             );
        }
    }
}