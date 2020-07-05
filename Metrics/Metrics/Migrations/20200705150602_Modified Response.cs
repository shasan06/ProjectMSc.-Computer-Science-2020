using Microsoft.EntityFrameworkCore.Migrations;

namespace Metrics.Migrations
{
    public partial class ModifiedResponse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "Responses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "Responses");
        }
    }
}
