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
        /// <param name="context">The data from the database used in this controller</param>
        /// <param name="userManagement">The interface being used to fill out user objects</param>
        public DefaultController(CodeTalkDBContext context, IUserManagement userManagement)
        {
            _context = context;
            _userManagement = userManagement;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Default>> GetDefaultById(int id)
        {
            return await _context.DefaultSnippets.FindAsync(id);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Default>>> GetAllDefaultsSaved()
        {
            return await _context.DefaultSnippets.ToListAsync();
        }


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

            var defaultObject = GetDefaultById(id).Result;
            string baseString = defaultObject.Value.BaseString;


            List<string> formDataList = InputData.CreateFormDataList(id, requestObject);
            string returnString = InputData.CreateSpokenCodeString(baseString, formDataList);


            User userObject = new User(codeName, returnString, inputsString)
            {
                Name = codeName,
                ReturnString = returnString,
                Input = inputsString
            };


            //var returnObject = await UserController.PostUser(userObject);
            var userEquals = await _userManagement.CreateUserAsync(userObject);
            return userEquals;

        }

    }
}