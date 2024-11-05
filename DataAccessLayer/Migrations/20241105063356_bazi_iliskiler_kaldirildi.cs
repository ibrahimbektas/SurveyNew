using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class bazi_iliskiler_kaldirildi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Surveys_SurveyID",
                table: "Responses");

            migrationBuilder.DropIndex(
                name: "IX_Responses_SurveyID",
                table: "Responses");

            migrationBuilder.DropColumn(
                name: "AnswerID",
                table: "UploadedFiles");

            migrationBuilder.DropColumn(
                name: "ConditionalQuestionID",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "QuestionID",
                table: "Options");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnswerID",
                table: "UploadedFiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConditionalQuestionID",
                table: "Options",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuestionID",
                table: "Options",
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
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
