using CodeTalkAPI.Data;
using CodeTalkAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalkAPI.Models.Services
{
    public class UserService : IUserManagement
    {
        private CodeTalkDBContext _context;

        /// <summary>
        /// Sets context of user snippet service
        /// </summary>
        /// <param name="context"></param>
        public UserService(CodeTalkDBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Saves to user snippet table user object as new record
        /// </summary>
        /// <param name="user">Object containing: Name, ReturnString and Input</param>
        /// <returns>New user snippet record</returns>
        public async Task<User> CreateUserAsync(User user)
        {
            _context.UserSnippets.Add(user);
            await _context.SaveChangesAsync();

            var postResult = await GetUserByIdAsync(user.Id);

            return postResult;
        }

        /// <summary>
        /// Lists all user snippet records
        /// </summary>
        /// <returns>All user snippet records in a list</returns>
        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _context.UserSnippets.ToListAsync();
            
        }

        /// <summary>
        /// Find a user snippet record by it's primary key
        /// </summary>
        /// <param name="id">Primary key for user snippet record</param>
        /// <returns>User snippet record with corresponding id</returns>
        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.UserSnippets.FindAsync(id);
        }

        /// <summary>
        /// Removes user snippet record from table/db
        /// </summary>
        /// <param name="id">Primary key for user snippet record</param>
        /// <returns>Nothing as user snippet record has been removed</returns>
        public async Task RemoveUserAsync(int id)
        {
            var userToDelete = await _context.UserSnippets.FindAsync(id);

            _context.UserSnippets.Remove(userToDelete);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Update details of a user snippet record
        /// </summary>
        /// <param name="user">Object with updated details</param>
        /// <returns>The user object details: Name, ReturnString, Input</returns>
        public async Task<User> UpdateUserAsync(User user)
        {
        
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
