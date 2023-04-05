using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity;


namespace Entities.Configuration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new
                {
                    RoleId = "bc6f72c0-66aa-4ec9-adb3-fba947bd0014",
                    UserId = "c3bdd301-35d1-4114-b5e4-78d509b5607c"
                }
            );
        }
    }
}
