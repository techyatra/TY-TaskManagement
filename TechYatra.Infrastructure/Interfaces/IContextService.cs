using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_List.Core.Entities;

namespace ToDo_List.Infrastructure.Interfaces
{
    public interface IContextService
    {
        User CreateUser(User user);
        User GetUserByName(string name);
        User GetUserById(int id);
        List<User> GetAllUsers();
        bool DeleteUser(User user);
        User UpdateUser(User user);
    }
}
