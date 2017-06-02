using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EmailUnsubscribe.Infrastructure.Contexts
{
    // Entity framework with authentication
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Retrieve the identity from cookie
            // Note the authenticationType must match the one defined in the CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    class EmailUnsubscribeDbContext  : IdentityDbContext<ApplicationUser>
    {
        public EmailUnsubscribeDbContext()
            :base("name=DbContextConnectionString", throwIfV1Schema: false)
        {
            
        }
    }
}
