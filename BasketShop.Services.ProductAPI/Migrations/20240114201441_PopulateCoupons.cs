using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasketShop.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulateCoupons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/ff50ee77-053c-4d83-9b51-980752e6e85a/koszulka-dla-duzych-nba-swingman-warriors-icon-edition-22VQBL.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://www.nike.com/pl/t/koszulka-dla-duzych-nba-swingman-warriors-icon-edition-22VQBL/CZ6212-495");
        }
    }
}
