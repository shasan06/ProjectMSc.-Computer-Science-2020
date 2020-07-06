using Microsoft.EntityFrameworkCore.Migrations;

namespace Metrics.Migrations
{
    public partial class ModifiedResponseRegistration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Responses");

            migrationBuilder.AddColumn<int>(
                name: "RegistrationId",
                table: "Responses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Registrations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Registrations",
                type: "nvarchar(250)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistrationId",
                table: "Responses");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Registrations");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Responses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
