using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_List.Core.Entities;
using ToDo_List.Infrastructure.Context;
using ToDo_List.Infrastructure.Interfaces;

namespace ToDo_List.Infrastructure.Services
{
    public class ContextService: IContextService
    {
        private readonly ToDoContext _context;
        public ContextService(ToDoContext context)
        {
            _context = context;
        }
        public User CreateUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
            return user;
        }

        public bool DeleteUser(User user)
        {
            try
            {
                _context.Remove(user);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public List<User> GetAllUsers()
        {
            var users = _context.Users.ToList();
            return users;
        }

        public User GetUserById(int id)
        {
            var user = _context.Users.SingleOrDefault(s => s.Id == id);
            return user;
        }

        public User GetUserByName(string name)
        {
            var user = _context.Users.SingleOrDefault(s => s.Name == name);
            return user;
        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
