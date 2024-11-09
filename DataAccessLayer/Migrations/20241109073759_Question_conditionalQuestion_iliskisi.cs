using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Question_conditionalQuestion_iliskisi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionID",
                table: "ConditionalQuestions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ConditionalQuestions_QuestionID",
                table: "ConditionalQuestions",
                column: "QuestionID");

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionalQuestions_Questions_QuestionID",
                table: "ConditionalQuestions",
                column: "QuestionID",
                principalTable: "Questions",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConditionalQuestions_Questions_QuestionID",
                table: "ConditionalQuestions");

            migrationBuilder.DropIndex(
                name: "IX_ConditionalQuestions_QuestionID",
                table: "ConditionalQuestions");

            migrationBuilder.DropColumn(
                name: "QuestionID",
                table: "ConditionalQuestions");
        }
    }
}
