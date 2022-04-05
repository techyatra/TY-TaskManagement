using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_List.Core.BaseEntities;

namespace ToDo_List.Core.Entities
{
    public class UserOrganisation: BaseEntity
    {
        public int UserId { get; set; }
        public User Users { get; set; }

        public int OrganisationId { get; set; }
        public Organisation Organisations { get; set; }
    }
}
