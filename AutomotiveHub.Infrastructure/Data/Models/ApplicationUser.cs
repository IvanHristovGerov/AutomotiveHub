using AutomotiveHub.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace AutomotiveHub.Infrastructure.Data.Models
{
    public class ApplicationUser
    {
        [Required]
        [MaxLength(DataConstants.UserFullNameMaxLength)]
        public string FullName {  get; set; } =string.Empty;

        public bool IsActive { get; set; } = true;
    }
}