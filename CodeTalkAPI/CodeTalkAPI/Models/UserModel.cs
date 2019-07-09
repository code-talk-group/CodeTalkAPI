using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalkAPI.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ReturnString { get; set; }

        ICollection<CodeModel> CodeModels { get; set; }
    }
}
