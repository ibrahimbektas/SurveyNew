using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class survey_response_iliskisi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SurveyID",
                table: "Responses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Responses_SurveyID",
                table: "Responses",
                column: "SurveyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Surveys_SurveyID",
                table: "Responses",
                column: "SurveyID",
                principalTable: "Surveys",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Surveys_SurveyID",
                table: "Responses");

            migrationBuilder.DropIndex(
                name: "IX_Responses_SurveyID",
                table: "Responses");

            migrationBuilder.DropColumn(
                name: "SurveyID",
                table: "Responses");
        }
    }
}
