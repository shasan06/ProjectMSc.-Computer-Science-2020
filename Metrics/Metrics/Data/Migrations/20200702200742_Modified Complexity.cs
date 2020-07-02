using Microsoft.EntityFrameworkCore.Migrations;

namespace Metrics.Migrations
{
    public partial class ModifiedComplexity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Complexities_Complexityid",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Complexities");

            migrationBuilder.RenameColumn(
                name: "Complexityid",
                table: "Images",
                newName: "ComplexityId");

            migrationBuilder.RenameIndex(
                name: "IX_Images_Complexityid",
                table: "Images",
                newName: "IX_Images_ComplexityId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Complexities",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Complexities_ComplexityId",
                table: "Images",
                column: "ComplexityId",
                principalTable: "Complexities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Complexities_ComplexityId",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "ComplexityId",
                table: "Images",
                newName: "Complexityid");

            migrationBuilder.RenameIndex(
                name: "IX_Images_ComplexityId",
                table: "Images",
                newName: "IX_Images_Complexityid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Complexities",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Complexities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Complexities_Complexityid",
                table: "Images",
                column: "Complexityid",
                principalTable: "Complexities",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
