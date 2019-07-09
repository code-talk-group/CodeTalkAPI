using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalkAPI.Models
{
    public class CodeTalkDBContext : DbContext
    {
        public CodeTalkDBContext(DbContextOptions<CodeTalkDBContext> options)
            : base(options)
        {
        }

        //Richard - Needs the DBSet for all the tables 

    }
}
