using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Food.Services.RestorantAPI1.Migrations
{
    public partial class addingCuiusine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cuisine",
                table: "Restorants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cuisine",
                table: "Restorants");
        }
    }
}
