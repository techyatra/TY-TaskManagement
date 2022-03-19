﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_List.Core.BaseEntities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
    }
}
