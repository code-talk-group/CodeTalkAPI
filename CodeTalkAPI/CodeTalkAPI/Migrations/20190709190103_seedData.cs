using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeTalkAPI.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DefaultSnippets",
                columns: new[] { "Id", "BaseString", "options" },
                values: new object[,]
                {
                    { 1, "*Method Name* is a public method with a void return type that takes in a *Data Type* called *Parameter* . When the method is called all the statements and arguments defined within the curly braces will run.", 0 },
                    { 2, "Needs the sentence", 1 },
                    { 3, "Needs the sentence", 3 },
                    { 4, "Needs the sentence", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DefaultSnippets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DefaultSnippets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DefaultSnippets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DefaultSnippets",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
