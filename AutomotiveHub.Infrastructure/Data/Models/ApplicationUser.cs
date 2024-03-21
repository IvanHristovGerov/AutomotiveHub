using AutomotiveHub.Infrastructure.Constants;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AutomotiveHub.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(DataConstants.UserFullNameMaxLength)]
        public string FullName { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}