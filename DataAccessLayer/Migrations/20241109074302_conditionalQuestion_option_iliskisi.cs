using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class conditionalQuestion_option_iliskisi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConditionalQuestionID",
                table: "Options",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Options_ConditionalQuestionID",
                table: "Options",
                column: "ConditionalQuestionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Options_ConditionalQuestions_ConditionalQuestionID",
                table: "Options",
                column: "ConditionalQuestionID",
                principalTable: "ConditionalQuestions",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_ConditionalQuestions_ConditionalQuestionID",
                table: "Options");

            migrationBuilder.DropIndex(
                name: "IX_Options_ConditionalQuestionID",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "ConditionalQuestionID",
                table: "Options");
        }
    }
}
