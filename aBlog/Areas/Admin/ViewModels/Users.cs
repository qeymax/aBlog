using aBlog.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace aBlog.Areas.Admin.ViewModels
{
    public class UsersIndex 
    {
        public List<aBlog.Models.User> Users;
        public List<aBlog.Models.Roles> Roles;
        public List<aBlog.Models.Roles_Users> Roles_Users;
    }

    public class UsersNew 
    {
        [Required , MaxLength(128)]
        public string Username { get; set; }
        [Required , DataType(DataType.Password)]
        public string Password { get; set; }
        [Required , DataType(DataType.EmailAddress), MaxLength(256)]
        public string Email { get; set; }

    }
    public class UsersEdit
    {
        [Required, MaxLength(128)]
        public string Username { get; set; }
        [Required, DataType(DataType.EmailAddress), MaxLength(256)]
        public string Email { get; set; }
    }
        
    public class UsersResetPassword
    {
        public string Username { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
