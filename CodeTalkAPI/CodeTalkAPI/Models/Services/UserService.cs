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

        public UserService(CodeTalkDBContext context)
        {
            _context = context;
        }

        public async Task<User> CreateUserAsync(User user)
        {
            _context.UserSnippets.Add(user);
            await _context.SaveChangesAsync();

            var postResult = await GetUserByIdAsync(user.Id);

            return postResult;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _context.UserSnippets.ToListAsync();
            
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.UserSnippets.FindAsync(id);
        }

        public async Task RemoveUserAsync(int id)
        {
            var userToDelete = await _context.UserSnippets.FindAsync(id);

            _context.UserSnippets.Remove(userToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<User> UpdateUserAsync(User user)
        {
        
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
