using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_List.Core.BaseEntities;
using ToDo_List.Core.Enums;

namespace ToDo_List.Core.Entities
{
    public class User: BaseEntity
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password  { get; set; }
        [MaxLength(50)]
        public string Mobile { get; set; }
        public string Address { get; set; }

        //[NotMapped]
        //public List<UserOrganisation> UserOrganisations { get; set; }
    }
}
