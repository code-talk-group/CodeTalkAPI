using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTalkAPI.Data;
using CodeTalkAPI.Models;
using CodeTalkAPI.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using CodeTalkAPI.Controllers;


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

        //GET api/default/4
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Default>> GetDefaultById(int id)
        {
            return await _context.DefaultSnippets.FindAsync(id); 
        }

        //GET api/default/Options/3
        [HttpGet("Options/{options:string}")]
        public async Task<ActionResult<List<Default>>> GetDefaultByOptions(string options)
        {
            Options newOption = (Options)Enum.Parse(typeof(Options), options);
            return await _context.DefaultSnippets.Where(d => d.Options == newOption).ToListAsync();
        }

        [HttpGet("{id:int}", Name = "Get")]
        public async Task<object> GetJSON([FromBody] object request)
        {
            var jsonObject = Convert.ToString(request);
            //alternative method var requestObject = (JObject)JsonConvert.DeserializeObject(jsonObject);
            var requestObject = JObject.Parse(jsonObject);
            var id = Convert.ToInt32(requestObject["ID"].ToString());
            var codeName = requestObject["CodeName"].ToString();
            object inputs = InputData.CreateObjectFromOptionReceived(id, requestObject);
            string inputsString = inputs.ToString();


            dynamic defaultObject = _context.DefaultSnippets.Find(id);
            string baseString = defaultObject.baseString;



            User userObject = new User(codeName, returnString, inputsString)
            {
                Name = codeName,
                ReturnString =
                Input = inputsString
            };

            var returnObject = await UserController.PostUser();
            return Ok(returnObject);
        }
    }
}