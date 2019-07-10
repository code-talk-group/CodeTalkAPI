using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalkAPI.Models
{
    public class User
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string ReturnString { get; set; }

        
        public string Input { get; set; }
        

        ICollection<Default> CodeModels { get; set; }
    }
}
