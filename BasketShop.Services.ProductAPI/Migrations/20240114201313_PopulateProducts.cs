using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasketShop.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulateProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Ball", "The latest model with improvements - the TF 1000 Legacy basketball, the official ball of PLK (Polska Liga Koszykarska)", "https://sklepkoszykarski.pl/userdata/public/gfx/6091/Oficjalna-pilka-Spalding-TF-1000-Legacy.jpg", "Spalding ball", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Board", "The Wilson mini basketball backboard is the perfect solution for any basketball fan who wants to play in the room", "https://sklepkoszykarski.pl/userdata/public/gfx/6381/Mini-tablica-do-koszykowki-Wilson-NBA-Los-Angeles-Lakers.jpg", "Wilson NBA Los Angeles Lakers mini basketball backboard", 150.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Shoes", "Satin shine and iconic colors are a combination you must have in your wardrobe. And a classic cut.", "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/1eac4e3d-869d-44f3-abb3-233eea2f68f1/buty-air-jordan-1-high-og-satin-bred-gmhC5X.png", "Air Jordan 1 High OG „Satin Bred", 800.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "T-shirt", "The Icon Edition T-shirt represents the true colors of the team and stands out with its distinctive, recognizable style. Inspired by the uniforms worn by professional players, the Nike NBA Swingman Golden State Warriors Icon Edition T-shirt is made of high-quality double-knit fabric and has a classic cut that looks great from any angle.", "https://www.nike.com/pl/t/koszulka-dla-duzych-nba-swingman-warriors-icon-edition-22VQBL/CZ6212-495", "Nike NBA Swingman T-shirt", 400.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Appetizer", " Quisque vel lacus ac magna, vehicula sagittis ut non lacus.<br/> Vestibulum arcu turpis, maximus malesuada neque. Phasellus commodo cursus pretium.", "https://placehold.co/603x403", "Samosa", 15.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Appetizer", " Quisque vel lacus ac magna, vehicula sagittis ut non lacus.<br/> Vestibulum arcu turpis, maximus malesuada neque. Phasellus commodo cursus pretium.", "https://placehold.co/602x402", "Paneer Tikka", 13.99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Dessert", " Quisque vel lacus ac magna, vehicula sagittis ut non lacus.<br/> Vestibulum arcu turpis, maximus malesuada neque. Phasellus commodo cursus pretium.", "https://placehold.co/601x401", "Sweet Pie", 10.99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Entree", " Quisque vel lacus ac magna, vehicula sagittis ut non lacus.<br/> Vestibulum arcu turpis, maximus malesuada neque. Phasellus commodo cursus pretium.", "https://placehold.co/600x400", "Pav Bhaji", 15.0 });
        }
    }
}
