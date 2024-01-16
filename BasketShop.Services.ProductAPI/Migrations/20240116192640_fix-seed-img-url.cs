using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasketShop.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class fixseedimgurl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://m.media-amazon.com/images/I/61cgmAgv1-S._AC_UF894,1000_QL80_.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://neonn.pl/data/gfx/pictures/large/7/0/8107_1.png?77480");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://sklepkoszykarski.pl/userdata/public/gfx/6091/Oficjalna-pilka-Spalding-TF-1000-Legacy.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://sklepkoszykarski.pl/userdata/public/gfx/6381/Mini-tablica-do-koszykowki-Wilson-NBA-Los-Angeles-Lakers.jpg");
        }
    }
}
