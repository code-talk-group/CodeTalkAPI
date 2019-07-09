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
        
        
        public DbSet<CodeModel> DefaultSnippets { get; set; }

        public DbSet<CodeModel> UserSnippets { get; set; }
    }
}
