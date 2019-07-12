﻿// <auto-generated />
using CodeTalkAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeTalkAPI.Migrations
{
    [DbContext(typeof(CodeTalkDBContext))]
    partial class CodeTalkDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeTalkAPI.Models.Default", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BaseString");

                    b.Property<int>("Options");

                    b.HasKey("Id");

                    b.ToTable("DefaultSnippets");

                    b.HasData(
                        new
                        {
                            Id = 1,

                            BaseString = "_ is a public method with a void return type that takes in a _ called _ . When the method is called all the statements and arguments defined within the curly braces will run.",

                            Options = 0
                        },
                        new
                        {
                            Id = 2,

                            BaseString = "_ is a public method which takes in an integer array called _ and returns an integer. A counter is declared and set to zero. A For Loop iterates through the array as long as i is less than the length of the array and adds 1 to the counter. When the loop is completed the counter is returned.",

                            Options = 1
                        },
                        new
                        {
                            Id = 3,
                            BaseString = "MethodName is a public method with a void return type that takes in an integer named pName. The integer's value is then set to userInt. Our if statement determines if pName is less than 10. If this is true, Yes is printed to the console. If this is not true, our else statement will print No to the console.",
                            Options = 2
                        },
                        new
                        {
                            Id = 4,
                            BaseString = "MethodName is a public method with a void return type. A dataType variable called varName is declared and set to equal userData.",
                            Options = 3
                        });
                });

            modelBuilder.Entity("CodeTalkAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Input");

                    b.Property<string>("Name");

                    b.Property<string>("ReturnString");

                    b.HasKey("Id");

                    b.ToTable("UserSnippets");
                });
#pragma warning restore 612, 618
        }
    }
}
