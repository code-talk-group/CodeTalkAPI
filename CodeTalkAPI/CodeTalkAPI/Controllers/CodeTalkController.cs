using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTalkAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeTalkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodeTalkController : ControllerBase
    {
        private readonly CodeTalkDBContext _context;

        public CodeTalkController(CodeTalkDBContext context)
        {
            _context = context;
            
        }

        //Richard - need to add routes
        

    }
}