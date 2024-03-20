using AutomotiveHub.Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomotiveHub.Infrastructure.Data.Models
{
    public class Dealership
    {
        [Key]
        [Comment("Dealership identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataConstants.DealershipNameMaxLength)]
        [Comment("Dealership's name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataConstants.DealershipAddressMaxLength)]
        [Comment("Dealership's address")]
        public string Address { get; set; } = string.Empty;

        [Required]
        public int CityId { get; set; }

        [ForeignKey(nameof(CityId))]
        public City City { get; set; } = null!;

        [Required]
        public int DealerId { get; set; }

        [ForeignKey(nameof(DealerId))]
        public Dealer Dealer { get; set; } = null!;
    }
}