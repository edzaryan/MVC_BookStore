using BookStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration 
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var user = new ApplicationUser()
            {
                Id = "c3bdd301-35d1-4114-b5e4-78d509b5607c",
                FirstName = "Edgar",
                LastName = "Yeghiazaryan",
                UserName = "edzaryan@gmail.com",
                NormalizedUserName = "EDZARYAN@GMAIL.COM",
                Email = "edzaryan@gmail.com",
                NormalizedEmail = "EDZARYAN@GMAIL.COM",
                LockoutEnabled = true,
                EmailConfirmed = true,
            };

            var ph = new PasswordHasher<ApplicationUser>();

            user.PasswordHash = ph.HashPassword(user, "1234");

            builder.HasData(user);
        }
    }
}
