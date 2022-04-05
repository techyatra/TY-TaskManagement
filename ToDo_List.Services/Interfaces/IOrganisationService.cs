using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_List.Core.Entities;

namespace ToDo_List.Services.Interfaces
{
    public interface IOrganisationService
    {
        List<Organisation> GetOrganisationsByUserId(int userId);
        List<User> GetAllUsersByOrganisationId(int id);
    }
}
