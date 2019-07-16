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
using CodeTalkAPI.Interfaces;
using System.Text;

namespace CodeTalkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private CodeTalkDBContext _context;
        private IUserManagement _userManagement;

        /// <summary>
        /// Setting default controller's database context and used interface
        /// </summary>
        /// <param name="context">The table/data from the database used in this controller</param>
        /// <param name="userManagement">The interface being used to fill out user objects</param>
        public DefaultController(CodeTalkDBContext context, IUserManagement userManagement)
        {
            _context = context;
            _userManagement = userManagement;
        }

        /// <summary>
        /// Request method that retrieves a default snippet's table record by ID
        /// </summary>
        /// <param name="id"> The primary key for the record on the default snippets table</param>
        /// <returns>The default snippets record with the matching ID</returns>
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Default>> GetDefaultById(int id)
        {
            return await _context.DefaultSnippets.FindAsync(id);
        }

        /// <summary>
        /// Request method that retrieves all records from the default snippet's table
        /// </summary>
        /// <returns>All records currently saved on the default snippet's table</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Default>>> GetAllDefaultsSaved()
        {
            return await _context.DefaultSnippets.ToListAsync();
        }

        /// <summary>
        /// Retrieves record from default snippet's table and grabs that record's base string.
        /// Then creates a user object and uses the object to create a new record on the user snippet's table.
        /// </summary>
        /// <param name="request">JSON object received when post action is requested</param>
        /// <returns>Object of new record created on the user snippet's table</returns>
        [HttpPost]
        public async Task<object> Post([FromBody] object request)
        {
            var jsonObject = Convert.ToString(request);
            //var requestObject = (JObject)JsonConvert.DeserializeObject(jsonObject);
            var requestObject = JObject.Parse(jsonObject);
            var id = Convert.ToInt32(requestObject["ID"].ToString());
            var codeName = requestObject["CodeName"].ToString();
            var inputs = InputData.CreateObjectFromOptionReceived(id, requestObject);

            StringBuilder sb = new StringBuilder();

            //Creates a string from all the input selections based on needed inputs for each option
            if (inputs is FunctionInput)
            {
                FunctionInput test = (FunctionInput)inputs;
                sb.Append($"{inputs.MethodName}, {test.DataType}, {test.ParameterName}");
            } 
            else if(inputs is ForLoopInput)
            {
                ForLoopInput test = (ForLoopInput)inputs;
                sb.Append($"{inputs.MethodName}, {test.ArrayName}");
            }
            else if (inputs is IfStatementInput)
            {
                IfStatementInput test = (IfStatementInput)inputs;
                sb.Append($"{inputs.MethodName}, {test.ParameterName}, {test.IntegerValue}");
            }
            else if (inputs is VariableInput)
            {
                VariableInput test = (VariableInput)inputs;
                sb.Append($"{inputs.MethodName}, {test.DataType}, {test.VariableName}, {test.VariableValue}");
            }

            string inputsString = sb.ToString();

            //Retrieve correct option record from default snippet's table and capturing appropriate base string to use
            var defaultObject = GetDefaultById(id).Result;
            string baseString = defaultObject.Value.BaseString;

            //Create a list by using correct option inputs and gathering received inputs from the JSON request object
            List<string> formDataList = InputData.CreateFormDataList(id, requestObject);
            //Uses the form data list and the correct base string to compile a return snippet, this is the spokecodestring
            string returnString = InputData.CreateSpokenCodeString(baseString, formDataList);

            //Creates a user object based off of the given option and inputs to use as the parameter for the new user snippet record
            User userObject = new User(codeName, returnString, inputsString)
            {
                Name = codeName,
                ReturnString = returnString,
                Input = inputsString
            };

            //Creates a new user snippet record on the user snippet table
            //var returnObject = await UserController.PostUser(userObject);
            var userEquals = await _userManagement.CreateUserAsync(userObject);
            return userEquals;

        }

    }
}