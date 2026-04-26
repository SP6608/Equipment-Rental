using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Equipment_Rental.Common
{
    public class RolesConfigurationEntity : IEntityTypeConfiguration<IdentityRole>
    {
        private readonly IEnumerable<IdentityRole> Roles =
            new List<IdentityRole>()
            { new IdentityRole { Id = "11111111-1111-1111-1111-111111111111",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = "22222222-2222-2222-2222-222222222222" },
              new IdentityRole { Id = "33333333-3333-3333-3333-333333333333",
                    Name = "User",
                    NormalizedName = "USER",
                    ConcurrencyStamp = "44444444-4444-4444-4444-444444444444" }
            };
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(Roles);
        }
    }
}
