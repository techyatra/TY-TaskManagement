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
        private object work;

        public object Works { get; private set; }

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
        public User UpdateUser(User user)
        {
            _context.Update(user);
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

        
        public Work CreateWork(Work work)
        {
            _context.Add(work);
            _context.SaveChanges();
            return work;
        }
        public List<Work> GetAllWorks()
        {
            var Works = _context.Works.ToList();
            return Works;
        }


        public Work UpdateWork(Work work)
        {
          _context.Update(work);
            _context.UpdateRange();
            return work;
        }


        public bool DeleteWork(Work work)
        {
            try
            {
                _context.Remove(work);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
