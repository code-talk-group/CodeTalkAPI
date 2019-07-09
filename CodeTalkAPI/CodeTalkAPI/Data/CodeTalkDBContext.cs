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
            //seed data 
            modelBuilder.Entity<Default>().HasData(
                new Default
                {
                    Id = 1,
                    BaseString = "*Method Name* is a public method with a void return type that takes in a *Data Type* called *Parameter* . When the method is called all the statements and arguments defined within the curly braces will run.",
                    options = Options.Function
                },
                new Default
                {
                    Id = 2,
                    BaseString = "Needs the sentence",
                    options = Options.For_Loop
                },
                new Default
                {
                    Id = 3,
                    BaseString = "Needs the sentence",
                    options = Options.Variable
                },
                new Default
                {
                    Id = 4,
                    BaseString = "Needs the sentence",
                    options = Options.If_Statement
                }
                );
        }

        public DbSet<Default> DefaultSnippets { get; set; }

        public DbSet<User> UserSnippets { get; set; }
    }
}
