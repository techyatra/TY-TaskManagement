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
        Work CreateWork(Work work);
        List<Work> GetAllWorks();
        Work UpdateWork(Work work);
        bool DeleteWork(Work work);
        User GetUserByEmail(string email);
        User GetUserByPhone(string phone);
        User GetUserByUserName(string userName);
        List<Organisation> GetOrganisationsByUserId(int userId);
        List<User> GetAllUsersByOrganisation(int Id);
        List<Work> GetUserWorks(int userId);
    }
}
