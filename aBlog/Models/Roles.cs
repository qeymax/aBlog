using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aBlog.Models
{
    public class Roles
    {
        public int Id { get; set; }
        public string Role { get; set; }

        public virtual List<Roles_Users> Roles_Users { get; set; }
    }
}