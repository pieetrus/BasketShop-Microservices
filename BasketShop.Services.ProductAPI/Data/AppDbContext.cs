using BasketShop.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BasketShop.Services.ProductAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Spalding ball",
                Price = 100,
                Description = "The latest model with improvements - the TF 1000 Legacy basketball, the official ball of PLK (Polska Liga Koszykarska)",
                ImageUrl = "https://m.media-amazon.com/images/I/61cgmAgv1-S._AC_UF894,1000_QL80_.jpg",
                CategoryName = "Ball"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Wilson NBA Los Angeles Lakers mini basketball backboard",
                Price = 150,
                Description = "The Wilson mini basketball backboard is the perfect solution for any basketball fan who wants to play in the room",
                ImageUrl = "https://neonn.pl/data/gfx/pictures/large/7/0/8107_1.png?77480",
                CategoryName = "Board"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Air Jordan 1 High OG „Satin Bred",
                Price = 800,
                Description = "Satin shine and iconic colors are a combination you must have in your wardrobe. And a classic cut.",
                ImageUrl = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/1eac4e3d-869d-44f3-abb3-233eea2f68f1/buty-air-jordan-1-high-og-satin-bred-gmhC5X.png",
                CategoryName = "Shoes"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Nike NBA Swingman T-shirt",
                Price = 400,
                Description = "The Icon Edition T-shirt represents the true colors of the team and stands out with its distinctive, recognizable style. Inspired by the uniforms worn by professional players, the Nike NBA Swingman Golden State Warriors Icon Edition T-shirt is made of high-quality double-knit fabric and has a classic cut that looks great from any angle.",
                ImageUrl = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/ff50ee77-053c-4d83-9b51-980752e6e85a/koszulka-dla-duzych-nba-swingman-warriors-icon-edition-22VQBL.png",
                CategoryName = "T-shirt"
            });
        }
    }
}
