using ApplicationCore.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public static class AppIdentityDbContextSeed
    {
        public static async Task SeedAsync(AppIdentityDbContext db, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            await db.Database.MigrateAsync();

            // admin rolünü olustur
            if (!await roleManager.RoleExistsAsync(AuthorizationConstants.Roles.ADMINISTRATOR))
            {
                await roleManager.CreateAsync(new IdentityRole(AuthorizationConstants.Roles.ADMINISTRATOR));
            }

            // admin
            if (!await userManager.Users.AnyAsync(u => u.UserName == AuthorizationConstants.DEFAULT_ADMIN_USER))
            {
                var adminUser = new ApplicationUser()
                {
                    UserName = AuthorizationConstants.DEFAULT_ADMIN_USER,
                    Email = AuthorizationConstants.DEFAULT_ADMIN_USER,
                    EmailConfirmed = true
                };
                await userManager.CreateAsync(adminUser, AuthorizationConstants.DEFAULT_PASSWORD);
                await userManager.AddToRoleAsync(adminUser, AuthorizationConstants.Roles.ADMINISTRATOR);
            }

            // demo 
            if (!await userManager.Users.AnyAsync(u => u.UserName == AuthorizationConstants.DEFAULT_DEMO_USER))
            {
                var demoUser = new ApplicationUser()
                {
                    UserName = AuthorizationConstants.DEFAULT_DEMO_USER,
                    Email = AuthorizationConstants.DEFAULT_DEMO_USER,
                    EmailConfirmed = true
                };
                await userManager.CreateAsync(demoUser, AuthorizationConstants.DEFAULT_PASSWORD);
            }

        }
    }
}
