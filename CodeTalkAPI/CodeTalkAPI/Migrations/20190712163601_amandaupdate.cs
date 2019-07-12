using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeTalkAPI.Migrations
{
    public partial class amandaupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DefaultSnippets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BaseString = table.Column<string>(nullable: true),
                    Options = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefaultSnippets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSnippets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ReturnString = table.Column<string>(nullable: true),
                    Input = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSnippets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DefaultSnippets",
                columns: new[] { "Id", "BaseString", "Options" },
                values: new object[,]
                {
                    { 1, "_ is a public method with a void return type that takes in a  _ called _. When the method is called all the statements and arguments defined within the curly braces will run.", 0 },
                    { 2, "_ is a public method which takes in an integer array called _ and returns an integer. A counter is declared and set to zero. A For Loop iterates through the array as long as i is less than the length of the array and adds 1 to the counter. When the loop is completed the counter is returned.", 1 },
                    { 3, "_ is a public method with a void return type that takes in an integer named _. The integer's value is then set to _. Our if statement determines if _ is less than 10. If this is true, Yes is printed to the console. If this is not true, our else statement will print No to the console.", 2 },
                    { 4, "_ is a public method with a void return type. A _ variable called _ is declared and set to equal _.", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DefaultSnippets");

            migrationBuilder.DropTable(
                name: "UserSnippets");
        }
    }
}
