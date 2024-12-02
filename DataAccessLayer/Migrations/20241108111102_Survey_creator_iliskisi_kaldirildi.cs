using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Survey_creator_iliskisi_kaldirildi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Surveys_SurveyID1",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SurveyID1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreatorID",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "SurveyID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SurveyID1",
                table: "AspNetUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatorID",
                table: "Surveys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SurveyID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SurveyID1",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SurveyID1",
                table: "AspNetUsers",
                column: "SurveyID1");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Surveys_SurveyID1",
                table: "AspNetUsers",
                column: "SurveyID1",
                principalTable: "Surveys",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
