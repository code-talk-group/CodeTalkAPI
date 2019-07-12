using CodeTalkAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalkAPI.Data
{
    public class CodeTalkDBContext : DbContext
    {
        public CodeTalkDBContext(DbContextOptions<CodeTalkDBContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seeded data 
            modelBuilder.Entity<Default>().HasData(
                new Default
                {
                    Id = 1,
                    BaseString = "MethodName is a public method with a void return type that takes in a UserDataType called ParamName. When the method is called all the statements and arguments defined within the curly braces will run.",
                    Options = Options.Function
                },
                new Default
                {
                    Id = 2,
                    BaseString = "MethodName is a public method which takes in an integer array called ArrayName and returns an integer. A counter is declared and set to zero. A For Loop iterates through the array as long as i is less than the length of the array and adds 1 to the counter. When the loop is completed the counter is returned.",
                    Options = Options.For_Loop
                },
                new Default
                {
                    Id = 3,
                    BaseString = "MethodName is a public method with a void return type that takes in an integer named pName. The integer's value is then set to userInt. Our if statement determines if pName is less than 10. If this is true, Yes is printed to the console. If this is not true, our else statement will print No to the console.",
                    Options = Options.If_Statement
                },
                new Default
                {
                    Id = 4,
                    BaseString = "MethodName is a public method with a void return type. A dataType variable called varName is declared and set to equal userData.",
                    Options = Options.Variable
                }
                );
        }

        public DbSet<Default> DefaultSnippets { get; set; }

        public DbSet<User> UserSnippets { get; set; }
    }
}
