using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class relation_of_survey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Users_SurveyID",
                table: "Users",
                column: "SurveyID");

            migrationBuilder.CreateIndex(
                name: "IX_Responses_SurveyID",
                table: "Responses",
                column: "SurveyID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SurveyID",
                table: "Questions",
                column: "SurveyID");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionalQuestions_SurveyID",
                table: "ConditionalQuestions",
                column: "SurveyID");

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionalQuestions_Surveys_SurveyID",
                table: "ConditionalQuestions",
                column: "SurveyID",
                principalTable: "Surveys",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Surveys_SurveyID",
                table: "Questions",
                column: "SurveyID",
                principalTable: "Surveys",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Surveys_SurveyID",
                table: "Responses",
                column: "SurveyID",
                principalTable: "Surveys",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Surveys_SurveyID",
                table: "Users",
                column: "SurveyID",
                principalTable: "Surveys",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConditionalQuestions_Surveys_SurveyID",
                table: "ConditionalQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Surveys_SurveyID",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Surveys_SurveyID",
                table: "Responses");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Surveys_SurveyID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SurveyID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Responses_SurveyID",
                table: "Responses");

            migrationBuilder.DropIndex(
                name: "IX_Questions_SurveyID",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_ConditionalQuestions_SurveyID",
                table: "ConditionalQuestions");
        }
    }
}
