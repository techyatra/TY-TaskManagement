using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDo_List.Infrastructure.Migrations
{
    public partial class userIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Works_Organizations_OrganisationId",
                table: "Works");

            migrationBuilder.DropForeignKey(
                name: "FK_Works_Users_UserId",
                table: "Works");

            migrationBuilder.DropIndex(
                name: "IX_Works_OrganisationId",
                table: "Works");

            migrationBuilder.DropIndex(
                name: "IX_Works_UserId",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "OrganisationId",
                table: "Works");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrganisationId",
                table: "Works",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Works_OrganisationId",
                table: "Works",
                column: "OrganisationId");

            migrationBuilder.CreateIndex(
                name: "IX_Works_UserId",
                table: "Works",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Organizations_OrganisationId",
                table: "Works",
                column: "OrganisationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Users_UserId",
                table: "Works",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
