using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace aBlog.Models
{
    public class Roles_Users
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Roles")]
        public int RoleId { get; set; }

        public virtual List<User> User { get; set; }
        public virtual List<Roles> Roles { get; set; }
    }
}