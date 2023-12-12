using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedMango_API.Migrations
{
    /// <inheritdoc />
    public partial class addOrderHeaderAndDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "OrderDetails");
        }
    }
}
