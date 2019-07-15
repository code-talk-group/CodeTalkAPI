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

        /// <summary>
        /// Setting user controller's context
        /// </summary>
        /// <param name="context">The table/data from the database being used for this controller</param>
        public UserController(CodeTalkDBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieval method that retrieves all records from the user snippet's table
        /// </summary>
        /// <returns>All records currently saved to the user snippet's table</returns>
        // GET api/user
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsersSaved()
        {
            return await _context.UserSnippets.ToListAsync();
            
        }
        
        /// <summary>
        /// Retreival method that retrieves a single record from the user snippet's table by ID
        /// </summary>
        /// <param name="id">The priamary key for the record from the user snippet's table</param>
        /// <returns>The matching record from the user snippet's table</returns>
        // GET api/user/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            return await _context.UserSnippets.FindAsync(id); 
        }

        /// <summary>
        /// Creation method that creates a new record on the user snippet's table
        /// </summary>
        /// <param name="user">Object that contains the new record details of: Name, ReturnString and Input</param>
        /// <returns>Newly created user snippet record</returns>
        // POST api/user
        [HttpPost]
        public async Task<ActionResult<User>> PostUser([Bind("Name,ReturnString")] User user)
        {
            _context.UserSnippets.Add(user);
            await _context.SaveChangesAsync();

            var postResult = await GetUserById(user.Id);

            return postResult;
        }

        /// <summary>
        /// Update method that will find the corresponding user snippet record and updates it's details
        /// </summary>
        /// <param name="id">Primary key for the user snippet record</param>
        /// <returns>Record object of the corresponding ID with any updated details saved to this record</returns>
        //// PUT api/user/5
        //[HttpPut("{id}")]
        //public async Task<ActionResult> UpdateUser(int id, User user)
        //{
        //    if(id != user.Id)
        //    {
        //        return BadRequest();
        //    }
        //    _context.Entry(user).State = EntityState.Modified;
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        /// <summary>
        /// Delete method that will find the corresponding user snippet record and remove it
        /// </summary>
        /// <param name="id">Primary key for the user snippet record</param>
        /// <returns>No content as record has been deleted</returns>
        //// PUT api/user/5
        // DELETE api/user/5
        [HttpDelete("{id}")] //might need to change so it can search by name 
        public async Task<IActionResult> Delete(int id)
        {
            var userToDelete = await _context.UserSnippets.FindAsync(id);

            if(userToDelete == null)
            {
                return NotFound();
            }

            _context.UserSnippets.Remove(userToDelete);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        /// <summary>
        /// Retreival method that will grab a record from the user table by it's name
        /// </summary>
        /// <param name="name">The name of the user snippet record</param>
        /// <returns>The corresponding record with the matching name</returns>
        // GET api/user/Name/name
        [HttpGet("Name/{name}")]
        public async Task<ActionResult<List<User>>> GetUserByName(string name)
        {
            return await _context.UserSnippets.Where(u => u.Name == name).ToListAsync(); 
        }
    }
}
