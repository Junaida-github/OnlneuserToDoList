using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineUsrToDoLst.Models
{
    public class UserIdentityDbContext: IdentityDbContext<UserIdentityUser>
    {
        public UserIdentityDbContext(): base("connectionstring")
        {

        }
    }

    public class UserIdentityUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class UserIdentityRole : IdentityRole
    {
        public UserIdentityRole()
        {

        }

        public UserIdentityRole(string roleName, string description)
            : base(roleName)
        {
            this.Description = description;
        }

        public string Description { get; set; }
    }
}