using aBlog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace aBlog.Areas.Admin.ViewModels
{
    public class UserContext : DbContext
    {
        public UserContext() : base("MainDb")
            {
            }
        public DbSet<Users> Users { get; set; }  
    }
}