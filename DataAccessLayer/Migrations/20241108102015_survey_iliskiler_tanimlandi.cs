using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class survey_iliskiler_tanimlandi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "IX_Users_SurveyID",
                table: "Users",
                column: "SurveyID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SurveyID",
                table: "Questions",
                column: "SurveyID");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionalQuestions_SurveyID",
                table: "ConditionalQuestions",
                column: "SurveyID");

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
                name: "FK_AspNetUsers_Surveys_SurveyID1",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionalQuestions_Surveys_SurveyID",
                table: "ConditionalQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Surveys_SurveyID",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Surveys_SurveyID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SurveyID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Questions_SurveyID",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_ConditionalQuestions_SurveyID",
                table: "ConditionalQuestions");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SurveyID1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SurveyID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SurveyID1",
                table: "AspNetUsers");
        }
    }
}
