using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class answer_option_iliskisi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnswerID",
                table: "Options",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Options_AnswerID",
                table: "Options",
                column: "AnswerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Answers_AnswerID",
                table: "Options",
                column: "AnswerID",
                principalTable: "Answers",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_Answers_AnswerID",
                table: "Options");

            migrationBuilder.DropIndex(
                name: "IX_Options_AnswerID",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "AnswerID",
                table: "Options");
        }
    }
}
