using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeTalkAPI.Migrations
{
    public partial class removeUserSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserSnippets",
                columns: new[] { "Id", "Input", "Name", "ReturnString" },
                values: new object[] { 1, "[i, am, a, string]", "Seeds", "Hello World im Testy" });

            migrationBuilder.InsertData(
                table: "UserSnippets",
                columns: new[] { "Id", "Input", "Name", "ReturnString" },
                values: new object[] { 2, null, "Another Seed", "Hello World im Testy 2" });

            migrationBuilder.InsertData(
                table: "UserSnippets",
                columns: new[] { "Id", "Input", "Name", "ReturnString" },
                values: new object[] { 3, null, "Seeds Part 3", "Hello World im Testy 3" });
        }
    }
}
