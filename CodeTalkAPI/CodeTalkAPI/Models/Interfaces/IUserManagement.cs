using CodeTalkAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalkAPI.Interfaces
{
    public interface IUserManagement
    {
        //create
        Task<User> CreateUserAsync(User user);
        
        //read
        Task<List<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);

        //update
        Task<User> UpdateUserAsync(User user);

        //delete
        Task RemoveUserAsync(int id);

    }
}
