using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RedMango_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeedMenuItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[,]
                {
                    { 1, "Appetizer", "Ushqim i shijshem kinez", "https://www.google.com/url?sa=i&url=https%3A%2F%2Frecipes.timesofindia.com%2Frecipes%2Fclub-sandwich%2Frs83740315.cms&psig=AOvVaw1JhUnBnfsTIV2cRI-0HQKl&ust=1702305252306000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCKDpp7GLhYMDFQAAAAAdAAAAABAD", "Spring Roll", 7.9900000000000002, "" },
                    { 2, "Appetizer", "Ushqim i shijshem kinez", "https://www.google.com/url?sa=i&url=https%3A%2F%2Frecipes.timesofindia.com%2Frecipes%2Fclub-sandwich%2Frs83740315.cms&psig=AOvVaw1JhUnBnfsTIV2cRI-0HQKl&ust=1702305252306000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCKDpp7GLhYMDFQAAAAAdAAAAABAD", "Spring Roll", 7.9900000000000002, "" },
                    { 3, "Appetizer", "Ushqim i shijshem kinez", "https://www.google.com/url?sa=i&url=https%3A%2F%2Frecipes.timesofindia.com%2Frecipes%2Fclub-sandwich%2Frs83740315.cms&psig=AOvVaw1JhUnBnfsTIV2cRI-0HQKl&ust=1702305252306000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCKDpp7GLhYMDFQAAAAAdAAAAABAD", "Spring Roll", 7.9900000000000002, "" },
                    { 4, "Appetizer", "Ushqim i shijshem kinez", "https://www.google.com/url?sa=i&url=https%3A%2F%2Frecipes.timesofindia.com%2Frecipes%2Fclub-sandwich%2Frs83740315.cms&psig=AOvVaw1JhUnBnfsTIV2cRI-0HQKl&ust=1702305252306000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCKDpp7GLhYMDFQAAAAAdAAAAABAD", "Spring Roll", 7.9900000000000002, "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
