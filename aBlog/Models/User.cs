using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace aBlog.Models
{
    public class Users
    {
        public  int Id { get; set; }
        public  string Username { get; set; }
        public  string Email { get; set; }
        public  string PasswordHash { get; set; }
    }
    


}