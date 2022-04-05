using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_List.Core.Entities;
using ToDo_List.Infrastructure.Interfaces;
using ToDo_List.Services.Interfaces;

namespace ToDo_List.Services.Services
{
    public class UserService: IUserService
    {
        public readonly IContextService _contextService;
        public UserService(IContextService contextService)
        {
            _contextService = contextService;
        }
        public List<User> GetAllUsers()
        {
            return _contextService.GetAllUsers();
        }
        public User CreateUser(User user)
        {
            return _contextService.CreateUser(user);
        }

        public User UpdateUser(User user)
        {
            return _contextService.UpdateUser(user);
        }

        public bool DeleteUser(int id)
        {
            var user = _contextService.GetUserById(id);
            if (user == null)
                throw new Exception("User Not Found");
            return _contextService.DeleteUser(user);
        }

        public User GetUserById(int id)
        {
            var user = _contextService.GetUserById(id);
            return user;
        }

        public User GetUserByUserName(string userName)
        {
            var user = _contextService.GetUserByUserName(userName);
            return user;
        }

        public User GetUserByName(string name)
        {
            var user = _contextService.GetUserByName(name);
           return user;
        }

        public User GetUserByEmail(string email)
        {
            var user = _contextService.GetUserByEmail(email);
            return user;
        }

        public User GetUserByPhone(string phone)
        {
            var user = _contextService.GetUserByPhone(phone);
            return user;
        }

        public User FindUser(string userName)
        {
            var user = new User();
            user = GetUserByUserName(userName);
            if (user == null)
                user = GetUserByEmail(userName);
            if (user == null)
                user = GetUserByPhone(userName);
            return user;
        }
        public User ResetPassword(string username, string password)
        {
            var user = GetUserByUserName(username);
            if (user == null)
                throw new Exception("invalid user");
            user.Password = password;
            var updatedUser = UpdateUser(user);
            return updatedUser;
        }
    }
}
