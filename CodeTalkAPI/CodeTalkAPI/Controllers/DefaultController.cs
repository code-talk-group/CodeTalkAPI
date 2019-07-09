using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTalkAPI.Data;
using CodeTalkAPI.Models;
using CodeTalkAPI.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeTalkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private CodeTalkDBContext _context;

        public DefaultController(CodeTalkDBContext context)
        {
            _context = context;
        }

        [HttpGet ("{options:int}", Name = "Get")]
        public Default Get(int option)
        {
            var defaultObject = _context.DefaultSnippets.Find(option);
            return defaultObject;
        }

        
    }
}