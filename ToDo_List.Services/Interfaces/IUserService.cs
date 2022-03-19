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
    }
}
