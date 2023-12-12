using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RedMango_API.Models;

namespace RedMango_API.Data
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options) 
        { 

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem
                {
                    Id = 1,
                    Name = "Spring Roll",
                    Description = "Ushqim i shijshem kinez",
                    //Image = "https://www.google.com/url?sa=i&url=https%3A%2F%2Frecipes.timesofindia.com%2Frecipes%2Fclub-sandwich%2Frs83740315.cms&psig=AOvVaw1JhUnBnfsTIV2cRI-0HQKl&ust=1702305252306000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCKDpp7GLhYMDFQAAAAAdAAAAABAD",
                    Price = 7.99,
                    Category = "Appetizer",
                    SpecialTag = ""
                },
                 new MenuItem
                 {
                     Id = 2,
                     Name = "Spring Roll",
                     Description = "Ushqim i shijshem kinez",
                     //Image = "https://www.google.com/url?sa=i&url=https%3A%2F%2Frecipes.timesofindia.com%2Frecipes%2Fclub-sandwich%2Frs83740315.cms&psig=AOvVaw1JhUnBnfsTIV2cRI-0HQKl&ust=1702305252306000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCKDpp7GLhYMDFQAAAAAdAAAAABAD",
                     Price = 7.99,
                     Category = "Appetizer",
                     SpecialTag = ""
                 },
                  new MenuItem
                  {
                      Id = 3,
                      Name = "Spring Roll",
                      Description = "Ushqim i shijshem kinez",
                     // Image = "https://www.google.com/url?sa=i&url=https%3A%2F%2Frecipes.timesofindia.com%2Frecipes%2Fclub-sandwich%2Frs83740315.cms&psig=AOvVaw1JhUnBnfsTIV2cRI-0HQKl&ust=1702305252306000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCKDpp7GLhYMDFQAAAAAdAAAAABAD",
                      Price = 7.99,
                      Category = "Appetizer",
                      SpecialTag = ""
                  }, 
                  new MenuItem
                  {
                      Id = 4,
                      Name = "Spring Roll",
                      Description = "Ushqim i shijshem kinez",
                      //Image = "https://www.google.com/url?sa=i&url=https%3A%2F%2Frecipes.timesofindia.com%2Frecipes%2Fclub-sandwich%2Frs83740315.cms&psig=AOvVaw1JhUnBnfsTIV2cRI-0HQKl&ust=1702305252306000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCKDpp7GLhYMDFQAAAAAdAAAAABAD",
                      Price = 7.99,
                      Category = "Appetizer",
                      SpecialTag = ""
                  });
        }

    }
}
