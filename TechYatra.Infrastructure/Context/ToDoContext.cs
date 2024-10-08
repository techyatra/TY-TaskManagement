﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_List.Core.Entities;

namespace ToDo_List.Infrastructure.Context
{
    public class ToDoContext:DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOrganisation> UserOrganisations { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet< Address> Addresses { get; set; }
        public DbSet<Organisation> Organizations { get; set; }

    }
}
