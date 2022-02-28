using Microsoft.EntityFrameworkCore.Migrations;

namespace PasteB.Migrations
{
    public partial class AddTimeBool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "PasteBins",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "PasteBins");
        }
    }
}
