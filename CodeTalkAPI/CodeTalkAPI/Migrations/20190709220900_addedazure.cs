using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeTalkAPI.Migrations
{
    public partial class addedazure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DefaultSnippets",
                keyColumn: "Id",
                keyValue: 1,
                column: "BaseString",
                value: "MethodName is a public method with a void return type that takes in a DataType called Parameter. When the method is called all the statements and arguments defined within the curly braces will run.");

            migrationBuilder.UpdateData(
                table: "DefaultSnippets",
                keyColumn: "Id",
                keyValue: 2,
                column: "BaseString",
                value: "MethodName is a public method which takes in an integer array with IntValue values and returns an integer. A counter is declared and set to zero. A `For Loop` iterates through the array as long as i is less than the length of the array and adds 1 to the counter. When the loop is broken the counter is returned.");

            migrationBuilder.UpdateData(
                table: "DefaultSnippets",
                keyColumn: "Id",
                keyValue: 3,
                column: "options",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DefaultSnippets",
                keyColumn: "Id",
                keyValue: 4,
                column: "options",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DefaultSnippets",
                keyColumn: "Id",
                keyValue: 1,
                column: "BaseString",
                value: "*Method Name* is a public method with a void return type that takes in a *Data Type* called *Parameter* . When the method is called all the statements and arguments defined within the curly braces will run.");

            migrationBuilder.UpdateData(
                table: "DefaultSnippets",
                keyColumn: "Id",
                keyValue: 2,
                column: "BaseString",
                value: "Needs the sentence");

            migrationBuilder.UpdateData(
                table: "DefaultSnippets",
                keyColumn: "Id",
                keyValue: 3,
                column: "options",
                value: 3);

            migrationBuilder.UpdateData(
                table: "DefaultSnippets",
                keyColumn: "Id",
                keyValue: 4,
                column: "options",
                value: 2);
        }
    }
}
