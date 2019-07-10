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

        //[HttpGet ("{options:int}", Name = "Get")]
        //public ActionResult<object> Get(int Id)
        //{
        //    var defaultObject = _context.DefaultSnippets.Find(Id);
        //    return defaultObject;
        //}

        [HttpGet]
        public ActionResult<Default> Get()
        {
            Default testobject = new Default
                {
                    Id = 1,
                    BaseString = "MethodName is a public method with a void return type that takes in a DataType called Parameter. When the method is called all the statements and arguments defined within the curly braces will run.",
                    Options = Options.Function
                };
            return testobject;
        }
    }
}