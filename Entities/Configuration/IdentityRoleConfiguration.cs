using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class IdentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new
                {
                    Id = "bc6f72c0-66aa-4ec9-adb3-fba947bd0014",
                    Name = "Admin",
                    ConcurrencyStamp = "1",
                    NormalizedName = "ADMIN"
                },
                new
                {
                    Id = "ff6f72c0-66aa-4ec9-adb3-fba947bd0014",
                    Name = "User",
                    ConcurrencyStamp = "2",
                    NormalizedName = "USER"
                }
            );
        }
    }
}
