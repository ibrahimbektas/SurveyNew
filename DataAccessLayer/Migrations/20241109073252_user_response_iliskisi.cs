using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class user_response_iliskisi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Responses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Responses_UserID",
                table: "Responses",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Users_UserID",
                table: "Responses",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Users_UserID",
                table: "Responses");

            migrationBuilder.DropIndex(
                name: "IX_Responses_UserID",
                table: "Responses");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Responses");
        }
    }
}
