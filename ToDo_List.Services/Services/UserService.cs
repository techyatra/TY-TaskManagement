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

    }
}
