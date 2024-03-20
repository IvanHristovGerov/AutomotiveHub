using AutomotiveHub.Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomotiveHub.Infrastructure.Data.Models
{
    public class Dealer
    {
        [Key]
        [Comment("Dealer identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataConstants.DealerNameMaxLength)]
        [Comment("Dealer's name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataConstants.DealerPhoneNumberMaxLength)]
        [Comment("Dealer phone number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        public IEnumerable<Car> Cars { get; set; } = new List<Car>();
    }
}