using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeTalkAPI.Migrations
{
    public partial class newproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InputCollection",
                table: "UserSnippets",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DefaultSnippets",
                keyColumn: "Id",
                keyValue: 1,
                column: "BaseString",
                value: "_ is a public method with a void return type that takes in a _ called _. When the method is called all the statements and arguments defined within the curly braces will run.");

            migrationBuilder.UpdateData(
                table: "DefaultSnippets",
                keyColumn: "Id",
                keyValue: 2,
                column: "BaseString",
                value: "_ is a public method which takes in an integer array with _ values and returns an integer. A counter is declared and set to zero. A `For Loop` iterates through the array as long as i is less than the length of the array and adds 1 to the counter. When the loop is broken the counter is returned.");

            migrationBuilder.UpdateData(
                table: "DefaultSnippets",
                keyColumn: "Id",
                keyValue: 3,
                column: "BaseString",
                value: "_ is a public method with a void return type that takes in an integer named _ . The integer's value is then set to _. Our if statement determines if _ is less than 10. If this is true, Yes is printed to the console. If this is not true, our else statement will print No to the console.");

            migrationBuilder.UpdateData(
                table: "DefaultSnippets",
                keyColumn: "Id",
                keyValue: 4,
                column: "BaseString",
                value: "_ is a public method with a void return type. A _ variable called _ is declared and set to equal _.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InputCollection",
                table: "UserSnippets");

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
                column: "BaseString",
                value: "Needs the sentence");

            migrationBuilder.UpdateData(
                table: "DefaultSnippets",
                keyColumn: "Id",
                keyValue: 4,
                column: "BaseString",
                value: "Needs the sentence");
        }
    }
}
