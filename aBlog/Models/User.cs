using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace aBlog.Models
{
    [Table("Users")]
    public class User
    {
        public  int Id { get; set; }
        public  string Username { get; set; }
        public  string Email { get; set; }
        public  string PasswordHash { get; set; }
        public virtual List<Roles_Users> Roles_Users { get; set; }
    }
    



}