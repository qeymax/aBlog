using aBlog.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace aBlog
{
    public class UsersContext : DbContext
    {
        public UsersContext() : base("MainDb")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Roles_Users> Roles_Users { get; set; }

    }
}