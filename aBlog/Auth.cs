using aBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aBlog
{
    public static class Auth
    {

        private const string UserKey = "aBlog.Auth.UserKey";

        public static User User
        {
           
            get
            {
                var userContext = new UsersContext();

                if (!HttpContext.Current.User.Identity.IsAuthenticated)
                    return null;

                var user = HttpContext.Current.Items[UserKey] as User;
                if (user == null)
                {
                    user = userContext.Users.FirstOrDefault(u => u.Username == HttpContext.Current.User.Identity.Name);

                    if (user == null)
                        return null;

                    HttpContext.Current.Items[UserKey] = user;
                }
                return user;
            }
        }
    }
}