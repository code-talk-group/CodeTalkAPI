using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeTalkAPI.Migrations
{
    public partial class adding_user_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "options",
                table: "DefaultSnippets",
                newName: "Options");

            migrationBuilder.InsertData(
                table: "UserSnippets",
                columns: new[] { "Id", "Name", "ReturnString" },
                values: new object[] { 1, "Seeds", "Hello World im Testy" });

            migrationBuilder.InsertData(
                table: "UserSnippets",
                columns: new[] { "Id", "Name", "ReturnString" },
                values: new object[] { 2, "Another Seed", "Hello World im Testy 2" });

            migrationBuilder.InsertData(
                table: "UserSnippets",
                columns: new[] { "Id", "Name", "ReturnString" },
                values: new object[] { 3, "Seeds Part 3", "Hello World im Testy 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserSnippets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserSnippets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserSnippets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "Options",
                table: "DefaultSnippets",
                newName: "options");
        }
    }
}
