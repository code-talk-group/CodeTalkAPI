﻿using System;
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
            object inputs = InputData.CreateObjectFromOptionReceived(id, requestObject);

            string inputsString = inputs.ToString();

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
            
            return RedirectToAction("PostUser", "User", userObject);

        }
    }
}