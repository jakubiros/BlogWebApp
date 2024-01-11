using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bloggie.Web.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var adminRoleId = "0df6a121-8194-4589-b060-1aac283d790d";

            var superAdminRoleId = "b4d1b1ba-7f3b-4815-9599-7fd5125addac";

            var userRoleId = "ddbf2d4f-4277-4bd9-aeaf-8ce5dec08ab6";

            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName= "Admin",
                    Id=adminRoleId,
                    ConcurrencyStamp = adminRoleId
                },
                new IdentityRole
                {
                    Name= "SuperAdmin",
                    NormalizedName="SuperAdmin",
                    Id=superAdminRoleId,
                    ConcurrencyStamp=superAdminRoleId
                },
                new IdentityRole
                {
                    Name="User",
                    NormalizedName="User",
                    Id=userRoleId,
                    ConcurrencyStamp=userRoleId
                }

            };

            builder.Entity<IdentityRole>().HasData(roles);


            var superAdminId = "2d00687a-da71-49b3-8bee-475532b24ac0";
            var superAdminUser = new IdentityUser
            {
                UserName = "superadmin@blog.com",
                Email = "superadmin@blog.com",
                NormalizedEmail = "superadmin@blog.com".ToUpper(),
                NormalizedUserName = "superadmin@blog.com".ToUpper(),
                Id = superAdminId
            };

            superAdminUser.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(superAdminUser, "superadmin123");

            builder.Entity<IdentityUser>().HasData(superAdminUser);

            var superAdminRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = superAdminId
                },
                new IdentityUserRole<string>
                {
                    RoleId =superAdminRoleId,
                    UserId = superAdminId
                },
                new IdentityUserRole<string>
                {
                    RoleId =userRoleId,
                    UserId = superAdminId
                }
            };

            builder.Entity<IdentityUserRole<string>>().HasData(superAdminRoles);
        }
    }
}
