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
                            BaseString = "METHODNAME is a public method with a void return type that takes in a  USERDATATYPE called PARAMNAME. When the method is called all the statements and arguments defined within the curly braces will run.",
                            Options = 0
                        },
                        new
                        {
                            Id = 2,
                            BaseString = "METHODNAME is a public method which takes in an integer array called ARRAYNAME and returns an integer. A counter is declared and set to zero. A For Loop iterates through the array as long as i is less than the length of the array and adds 1 to the counter. When the loop is completed the counter is returned.",
                            Options = 1
                        },
                        new
                        {
                            Id = 3,
                            BaseString = "METHODNAME is a public method with a void return type that takes in an integer named PNAME. The integer's value is then set to USERINT. Our if statement determines if PNAME is less than 10. If this is true, Yes is printed to the console. If this is not true, our else statement will print No to the console.",
                            Options = 2
                        },
                        new
                        {
                            Id = 4,
                            BaseString = "METHODNAME is a public method with a void return type. A DATATYPE variable called VARNAME is declared and set to equal USERDATA.",
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Input = "[i, am, a, string]",
                            Name = "Seeds",
                            ReturnString = "Hello World im Testy"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Another Seed",
                            ReturnString = "Hello World im Testy 2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Seeds Part 3",
                            ReturnString = "Hello World im Testy 3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
