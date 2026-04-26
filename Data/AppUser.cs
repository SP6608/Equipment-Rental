using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Equipment_Rental.Data
{
    public class AppUser:IdentityUser
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = null!;
        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = null!;
    }
}
