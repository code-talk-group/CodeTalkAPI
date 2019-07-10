using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalkAPI.Models
{
    public class Default
    {
        
        public int Id { get; set; }

        public string BaseString { get; set; }

        public Options Options { get; set; }

        ICollection<User> UserModels { get; set; }
    }

    public enum Options
    {
        Function = 0,
        For_Loop = 1,
        If_Statement = 2,
        Variable = 3,
    }
    

}
