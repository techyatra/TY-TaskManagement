using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_List.Core.BaseEntities;
using ToDo_List.Core.Enums;

namespace ToDo_List.Core.Entities
{
    public class User: BaseEntity
    {
        public string? NationalIDNumber { get; set; }
        public string? Name { get; set; }
        public string? Qualification { get; set; }
        public string? LoginID { get; set; }
        public string? JobTitle { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool MaritalStatus { get; set; }
        public Gender Gender { get; set; }
        public Guid? RowGuid { get; set; }
        [MaxLength(50)]
        public string Phone { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
