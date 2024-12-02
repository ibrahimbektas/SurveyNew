using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Survey_creator_iliskisi_tekrar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatorID",
                table: "Surveys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Surveys_CreatorID",
                table: "Surveys",
                column: "CreatorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_AspNetUsers_CreatorID",
                table: "Surveys",
                column: "CreatorID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_AspNetUsers_CreatorID",
                table: "Surveys");

            migrationBuilder.DropIndex(
                name: "IX_Surveys_CreatorID",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "CreatorID",
                table: "Surveys");
        }
    }
}
