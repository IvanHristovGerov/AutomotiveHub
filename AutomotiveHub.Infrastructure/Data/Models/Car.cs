using AutomotiveHub.Infrastructure.Constants;
using AutomotiveHub.Infrastructure.Enumerations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomotiveHub.Infrastructure.Data.Models
{
    public class Car
    {
        [Key]
        [Comment("Car identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataConstants.CarBrandMaxLength)]
        [Comment("Brand name")]
        public string Brand { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataConstants.CarModelMaxLength)]
        [Comment("Model name")]
        public string Model { get; set; } = string.Empty;

        [Required]
        [Comment("Year of production")]
        public int Year { get; set; }

        [Required]
        [MaxLength(DataConstants.CarKilometersMaxValue)]
        [Comment("Car's mileage")]
        public int Kilometers { get; set; }

        [Required]
        [MaxLength(DataConstants.CarDescriptionMaxLength)]
        [Comment("Car's description")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("Transmission type")]
        public Transmission Transmission { get; set; }

        [Required]
        [Comment("Fuel type")]
        public Fuel Fuel { get; set; }

        [Required]
        [Comment("Price per day")]
        public int PricePerDay { get; set; }

        [Required]
        [MaxLength(DataConstants.CarImageUrlMaxLength)]
        [Comment("Image URL")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        [Comment("Category identifier")]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(Category))]
        public Category Category { get; set; } = null!;


        [Required]
        [Comment("Dealer identifier")]
        public int DealerId { get; set; }

        [ForeignKey(nameof(DealerId))]
        public Dealer Dealer { get; set; } = null!;


        [Comment("User Id of the renterer")]
        public string? RenterId { get; set; }

        [ForeignKey(nameof(RenterId))]
        public ApplicationUser? Renter { get; set; }






    }
}
