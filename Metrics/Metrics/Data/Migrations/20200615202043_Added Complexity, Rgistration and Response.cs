using Microsoft.EntityFrameworkCore.Migrations;

namespace Metrics.Data.Migrations
{
    public partial class AddedComplexityRgistrationandResponse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Complexities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelId = table.Column<int>(nullable: false),
                    Range = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    Compare = table.Column<int>(nullable: false),
                    Add = table.Column<int>(nullable: false),
                    Subtract = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complexities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(nullable: false),
                    Speed = table.Column<int>(nullable: false),
                    Timestamp = table.Column<int>(nullable: false),
                    QuestionId = table.Column<string>(nullable: true),
                    LevelId = table.Column<string>(nullable: true),
                    Answer = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complexities");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
