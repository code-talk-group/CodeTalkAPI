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
                    BaseString = "METHODNAME is a public method with a void return type that takes in a  USERDATATYPE called PARAMNAME. When the method is called all the statements and arguments defined within the curly braces will run.",
                    Options = Options.Function
                },
                new Default
                {
                    Id = 2,
                    BaseString = "METHODNAME is a public method which takes in an integer array called ARRAYNAME and returns an integer. A counter is declared and set to zero. A For Loop iterates through the array as long as i is less than the length of the array and adds 1 to the counter. When the loop is completed the counter is returned.",
                    Options = Options.For_Loop
                },
                new Default
                {
                    Id = 3,
                    BaseString = "METHODNAME is a public method with a void return type that takes in an integer named PNAME. The integer's value is then set to USERINT. Our if statement determines if PNAME is less than 10. If this is true, Yes is printed to the console. If this is not true, our else statement will print No to the console.",
                    Options = Options.If_Statement
                },
                new Default
                {
                    Id = 4,
                    BaseString = "METHODNAME is a public method with a void return type. A DATATYPE variable called VARNAME is declared and set to equal USERDATA.",
                    Options = Options.Variable
                }
                );
        }

        public DbSet<Default> DefaultSnippets { get; set; }

        public DbSet<User> UserSnippets { get; set; }
    }
}
