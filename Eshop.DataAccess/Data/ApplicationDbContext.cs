using Eshop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Eshop.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Novel", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Action", DisplayOrder = 3 }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "CocaCola1",
                    Author = "Tianqi Tang1",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "TTQ0000001",
                    ListPrice = 99,
                    Price = 90,
                    PriceFifty = 85,
                    PriceHundred = 80,
                    CategoryId = 1,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 2,
                    Title = "CocaCola2",
                    Author = "Tianqi Tang2",
                    Description = "CocaCola classic.\r\n\r\nThe Baron Crispy Corn Nibbles. ",
                    ISBN = "TTQ0000002",
                    ListPrice = 40,
                    Price = 30,
                    PriceFifty = 25,
                    PriceHundred = 20,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "CocaCola3",
                    Author = "Tianqi Tang3",
                    Description = "CocaCola classic.\r\n\r\nThe Baron Crispy Corn Nibbles. ",
                    ISBN = "TTQ0000003",
                    ListPrice = 55,
                    Price = 50,
                    PriceFifty = 40,
                    PriceHundred = 35,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "CocaCola4",
                    Author = "Tianqi Tang4",
                    Description = "CocaCola classic.\r\n\r\nThe Baron Crispy Corn Nibbles. ",
                    ISBN = "TTQ0000004",
                    ListPrice = 70,
                    Price = 65,
                    PriceFifty = 60,
                    PriceHundred = 55,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "CocaCola5",
                    Author = "Tianqi Tang5",
                    Description = "CocaCola classic.\r\n\r\nThe Baron Crispy Corn Nibbles.  ",
                    ISBN = "TTQ0000005",
                    ListPrice = 30,
                    Price = 27,
                    PriceFifty = 25,
                    PriceHundred = 20,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "CocaCola6",
                    Author = "Tianqi Tang6",
                    Description = "CocaCola classic.\r\n\r\nThe Baron Crispy Corn Nibbles.  ",
                    ISBN = "TTQ0000006",
                    ListPrice = 25,
                    Price = 23,
                    PriceFifty = 22,
                    PriceHundred = 20,
                    CategoryId = 12,
                    ImageUrl = ""
                }
                );
        }
    }
}
