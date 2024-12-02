using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class conditionalQuestions_silindi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_ConditionalQuestions_ConditionalQuestionID",
                table: "Options");

            migrationBuilder.DropTable(
                name: "ConditionalQuestions");

            migrationBuilder.DropIndex(
                name: "IX_Options_ConditionalQuestionID",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "ConditionalQuestionID",
                table: "Options");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Questions",
                newName: "QuestionType");

            migrationBuilder.AddColumn<string>(
                name: "AnswerType",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ChildID",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentID",
                table: "Questions",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswerType",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "ChildID",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "ParentID",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "QuestionType",
                table: "Questions",
                newName: "Type");

            migrationBuilder.AddColumn<int>(
                name: "ConditionalQuestionID",
                table: "Options",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ConditionalQuestions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionID = table.Column<int>(type: "int", nullable: false),
                    SurveyID = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionalQuestions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ConditionalQuestions_Questions_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Questions",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ConditionalQuestions_Surveys_SurveyID",
                        column: x => x.SurveyID,
                        principalTable: "Surveys",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Options_ConditionalQuestionID",
                table: "Options",
                column: "ConditionalQuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionalQuestions_QuestionID",
                table: "ConditionalQuestions",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionalQuestions_SurveyID",
                table: "ConditionalQuestions",
                column: "SurveyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Options_ConditionalQuestions_ConditionalQuestionID",
                table: "Options",
                column: "ConditionalQuestionID",
                principalTable: "ConditionalQuestions",
                principalColumn: "ID");
        }
    }
}
