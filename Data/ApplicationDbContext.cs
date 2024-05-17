using EmployeeManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employees> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRoles(builder);
            SeedUsers(builder);
            SeedUserRoles(builder);
        }

        private void SeedUsers(ModelBuilder builder)
        {
            User user = new User()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                UserName = "Admin@gmail.com",
                NormalizedUserName = "Admin@gmail.com",
                Email = "Admin@gmail.com",
                EmailConfirmed = true,
                NormalizedEmail = "Admin@gmail.com",
                LockoutEnabled = true,
                PhoneNumber = "1234567890",
            };
            var passwordHasher = new PasswordHasher<User>();
            user.PasswordHash = passwordHasher.HashPassword(user, "Admin@123");
            builder.Entity<User>().HasData(user);
        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = "fab4fac1-c546-41de-aebc-a14da6895711",
                    Name = "Admin",
                    ConcurrencyStamp = "1",
                    NormalizedName = "ADMIN"
                }
            );
        }

        private void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>()
                {
                    RoleId = "fab4fac1-c546-41de-aebc-a14da6895711",
                    UserId = "b74ddd14-6340-4840-95c2-db12554843e5"
                }
            );
        }
    }
}
