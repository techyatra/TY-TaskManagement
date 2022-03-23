using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_List.Core.Entities;

namespace ToDo_List.Services.Interfaces
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        User CreateUser(User user);
        User UpdateUser(User user);
        bool DeleteUser(int id);
        User GetUserById(int id);
        User GetUserByUserName(string userName);
        User GetUserByName(string userName);
        User GetUserByEmail(string email);
        User GetUserByPhone(string phone);
    }
}
