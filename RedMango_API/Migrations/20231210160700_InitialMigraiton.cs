using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedMango_API.Migrations
{
    /// <inheritdoc />
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "MenuItems");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "MenuItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Frecipes.timesofindia.com%2Frecipes%2Fclub-sandwich%2Frs83740315.cms&psig=AOvVaw1JhUnBnfsTIV2cRI-0HQKl&ust=1702305252306000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCKDpp7GLhYMDFQAAAAAdAAAAABAD");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Frecipes.timesofindia.com%2Frecipes%2Fclub-sandwich%2Frs83740315.cms&psig=AOvVaw1JhUnBnfsTIV2cRI-0HQKl&ust=1702305252306000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCKDpp7GLhYMDFQAAAAAdAAAAABAD");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Frecipes.timesofindia.com%2Frecipes%2Fclub-sandwich%2Frs83740315.cms&psig=AOvVaw1JhUnBnfsTIV2cRI-0HQKl&ust=1702305252306000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCKDpp7GLhYMDFQAAAAAdAAAAABAD");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Frecipes.timesofindia.com%2Frecipes%2Fclub-sandwich%2Frs83740315.cms&psig=AOvVaw1JhUnBnfsTIV2cRI-0HQKl&ust=1702305252306000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCKDpp7GLhYMDFQAAAAAdAAAAABAD");
        }
    }
}
