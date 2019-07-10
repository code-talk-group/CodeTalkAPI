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
        [HttpGet("{id}")]
        public async Task<ActionResult<Default>> GetDefaultById(int id)
        {
            return await _context.DefaultSnippets.FindAsync(id); //might need to find it by name 
        }

        //GET api/default/Options/3
        [HttpGet("Options/{options}")]
        public async Task<ActionResult<List<Default>>> GetDefaultByOptions(string options)
        {
            Options newOption = (Options)Enum.Parse(typeof(Options), options);
            return await _context.DefaultSnippets.Where(d => d.Options == newOption).ToListAsync();
        }
    }
}