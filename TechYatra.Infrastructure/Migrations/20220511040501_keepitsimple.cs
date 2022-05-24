using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDo_List.Infrastructure.Migrations
{
    public partial class keepitsimple : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOrganisations_Organizations_OrganisationId",
                table: "UserOrganisations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserOrganisations_Users_UserId",
                table: "UserOrganisations");

            migrationBuilder.DropIndex(
                name: "IX_UserOrganisations_OrganisationId",
                table: "UserOrganisations");

            migrationBuilder.DropIndex(
                name: "IX_UserOrganisations_UserId",
                table: "UserOrganisations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UserOrganisations_OrganisationId",
                table: "UserOrganisations",
                column: "OrganisationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrganisations_UserId",
                table: "UserOrganisations",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrganisations_Organizations_OrganisationId",
                table: "UserOrganisations",
                column: "OrganisationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrganisations_Users_UserId",
                table: "UserOrganisations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
