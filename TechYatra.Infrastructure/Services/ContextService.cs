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
                _context.SaveChanges();
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

        public User GetUserByUserName(string userName)
        {
            var user = _context.Users.SingleOrDefault(s => s.UserName == userName);
            return user;
        }


        public User GetUserByPhone(string phone)
        {
            var user = _context.Users.SingleOrDefault(u => u.Mobile == phone);
            return user;
        }

        public User GetUserByEmail(string email)
        {
            var user = _context.Users.SingleOrDefault(u => u.Email == email);
            return user;
        }

        public List<User> GetAllUsersByOrganisation(int id)
        {
            var organisation = _context.Organizations.SingleOrDefault(o => o.Id == id);
            if (organisation == null)
                throw new Exception("invalid organisation id");
            var organisationUsers = _context.UserOrganisations.Where(o => o.OrganisationId == organisation.Id).ToList();
            var userIds = organisationUsers.Select(u => u.UserId).ToList();
            var users = _context.Users.Where(u => userIds.Contains(u.Id)).ToList();
            return users;
        }

        public List<Organisation> GetOrganisationsByUserId(int userId)
        {
            var user = GetUserById(userId);
            if (user == null)
                throw new Exception("user not found");
            var userOrganisations = _context.UserOrganisations.Where(u => u.UserId == userId).ToList();
            if (userOrganisations.Count() == 0)
                throw new Exception("user has no organisations");
            var organisationIds = userOrganisations.Select(s => s.OrganisationId).Distinct().ToList();
            var organisations = _context.Organizations.Where(o => organisationIds.Contains(o.Id)).ToList();
            return organisations;
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
        
        public List<Work> GetUserWorks(int userId)
        {
            var works = _context.Works.Where(w => w.UserId == userId && w.IsDeleted == false).ToList();
            return works;
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
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
