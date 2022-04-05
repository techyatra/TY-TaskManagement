using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDo_List.Infrastructure.Migrations
{
    public partial class o : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOrganisation_Organizations_OrganisationId",
                table: "UserOrganisation");

            migrationBuilder.DropForeignKey(
                name: "FK_UserOrganisation_Users_UserId",
                table: "UserOrganisation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserOrganisation",
                table: "UserOrganisation");

            migrationBuilder.RenameTable(
                name: "UserOrganisation",
                newName: "UserOrganisations");

            migrationBuilder.RenameIndex(
                name: "IX_UserOrganisation_UserId",
                table: "UserOrganisations",
                newName: "IX_UserOrganisations_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserOrganisation_OrganisationId",
                table: "UserOrganisations",
                newName: "IX_UserOrganisations_OrganisationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserOrganisations",
                table: "UserOrganisations",
                column: "Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOrganisations_Organizations_OrganisationId",
                table: "UserOrganisations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserOrganisations_Users_UserId",
                table: "UserOrganisations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserOrganisations",
                table: "UserOrganisations");

            migrationBuilder.RenameTable(
                name: "UserOrganisations",
                newName: "UserOrganisation");

            migrationBuilder.RenameIndex(
                name: "IX_UserOrganisations_UserId",
                table: "UserOrganisation",
                newName: "IX_UserOrganisation_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserOrganisations_OrganisationId",
                table: "UserOrganisation",
                newName: "IX_UserOrganisation_OrganisationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserOrganisation",
                table: "UserOrganisation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrganisation_Organizations_OrganisationId",
                table: "UserOrganisation",
                column: "OrganisationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrganisation_Users_UserId",
                table: "UserOrganisation",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
