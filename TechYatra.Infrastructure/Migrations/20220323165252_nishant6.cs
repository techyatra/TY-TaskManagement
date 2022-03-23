using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDo_List.Infrastructure.Migrations
{
    public partial class nishant6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Users_UserId",
                table: "Addresses");

            migrationBuilder.DropTable(
                name: "OrganisationUser");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Addresses");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Organizations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_UserId",
                table: "Organizations",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_Users_UserId",
                table: "Organizations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_Users_UserId",
                table: "Organizations");

            migrationBuilder.DropIndex(
                name: "IX_Organizations_UserId",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Organizations");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Addresses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrganisationUser",
                columns: table => new
                {
                    OrganisationsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganisationUser", x => new { x.OrganisationsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_OrganisationUser_Organizations_OrganisationsId",
                        column: x => x.OrganisationsId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrganisationUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationUser_UsersId",
                table: "OrganisationUser",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Users_UserId",
                table: "Addresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
