using Microsoft.EntityFrameworkCore.Migrations;

namespace Metrics.Migrations
{
    public partial class removednavigationpropertiesonImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Registrations_RegistrationId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Responses_ResponseId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_RegistrationId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_ResponseId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "RegistrationId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ResponseId",
                table: "Images");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RegistrationId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResponseId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_RegistrationId",
                table: "Images",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ResponseId",
                table: "Images",
                column: "ResponseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Registrations_RegistrationId",
                table: "Images",
                column: "RegistrationId",
                principalTable: "Registrations",
                principalColumn: "RegistrationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Responses_ResponseId",
                table: "Images",
                column: "ResponseId",
                principalTable: "Responses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
