using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_List.Core.BaseEntities;

namespace ToDo_List.Core.Entities
{
    public class Organisation: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Purpose { get; set; }
        public List<UserOrganisation> OrganisationUsers { get; set; }
    }
}
