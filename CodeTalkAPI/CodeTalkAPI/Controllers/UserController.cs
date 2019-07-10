using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTalkAPI.Data;
using CodeTalkAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeTalkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly CodeTalkDBContext _context;

        public UserController(CodeTalkDBContext context)
        {
            _context = context;
        }


        // GET api/user
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsersSaved()
        {
            return await _context.UserSnippets.ToListAsync();
            
        }

        // GET api/user/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            return await _context.UserSnippets.FindAsync(id); //might need to find it by name 
        }

        // POST api/user
        [HttpPost]
        public async Task<ActionResult<User>> PostUser([Bind("Name,ReturnString")] User user)
        {
             _context.UserSnippets.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }

        // PUT api/user/5
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateUser(int id, User user)
        {
            if(id != user.Id)
            {
                return BadRequest();
            }
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
