using AutomotiveHub.Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AutomotiveHub.Infrastructure.Data.Models
{
    public class Category
    {
        [Key]
        [Comment("Category identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataConstants.CarDescriptionMaxLength)]
        [Comment("Category's name")]
        public string Name { get; set; } = string.Empty;

        public IEnumerable<Car> Cars { get; set; } = new List<Car>();
    }
}