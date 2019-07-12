using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeTalkAPI.Migrations
{
    public partial class newdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DefaultSnippets",
                keyColumn: "Id",
                keyValue: 1,
                column: "BaseString",
                value: "MethodName is a public method with a void return type that takes in a *UserDataType* called *ParamName* . When the method is called all the statements and arguments defined within the curly braces will run.");

            migrationBuilder.UpdateData(
                table: "DefaultSnippets",
                keyColumn: "Id",
                keyValue: 2,
                column: "BaseString",
                value: "MethodName is a public method which takes in an integer array called ArrayName and returns an integer. A counter is declared and set to zero. A For Loop iterates through the array as long as i is less than the length of the array and adds 1 to the counter. When the loop is completed the counter is returned.");

            migrationBuilder.UpdateData(
                table: "DefaultSnippets",
                keyColumn: "Id",
                keyValue: 3,
                column: "BaseString",
                value: "MethodName is a public method with a void return type that takes in an integer named pName . The integer's value is then set to userInt. Our if statement determines if pName is less than 10. If this is true, Yes is printed to the console. If this is not true, our else statement will print No to the console.");

            migrationBuilder.UpdateData(
                table: "DefaultSnippets",
                keyColumn: "Id",
                keyValue: 4,
                column: "BaseString",
                value: "MethodName is a public method with a void return type. A dataType variable called varName is declared and set to equal userData.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
