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
    public class OrganisationService : IOrganisationService
    {
        private readonly IContextService _context;
        public OrganisationService(IContextService context)
        {
            _context = context;
        }

        public List<User> GetAllUsersByOrganisationId(int id)
        {
            var data = _context.GetAllUsersByOrganisation(id);
            return data;
        }

        public List<Organisation> GetOrganisationsByUserId(int userId)
        {
            var organisations = _context.GetOrganisationsByUserId(userId);
            return organisations;

        }
    }
}
