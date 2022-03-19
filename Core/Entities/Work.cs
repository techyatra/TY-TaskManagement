using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_List.Core.BaseEntities;
using ToDo_List.Core.Enums;

namespace ToDo_List.Core.Entities
{
    public class Work: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsAssigned { get; set; }
        public WorkPriority Priority { get; set; }
        public WorkStatus Status { get; set; }
        public DateTime? AssignedAt { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }


    }
}
