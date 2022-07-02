using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArticleId",
                table: "Commands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Commands_ArticleId",
                table: "Commands",
                column: "ArticleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Articles_ArticleId",
                table: "Commands",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Articles_ArticleId",
                table: "Commands");

            migrationBuilder.DropIndex(
                name: "IX_Commands_ArticleId",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "ArticleId",
                table: "Commands");
        }
    }
}
