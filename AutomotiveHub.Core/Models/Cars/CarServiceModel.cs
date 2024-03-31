using AutomotiveHub.Core.Contracts;
using AutomotiveHub.Infrastructure.Enumerations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static AutomotiveHub.Core.Constants.MessageConstants;
using static AutomotiveHub.Infrastructure.Constants.DataConstants;

namespace AutomotiveHub.Core.Models.Cars
{
    public class CarServiceModel : ICarServiceModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = RequireMessage)]
        [StringLength(CarBrandMaxLength, MinimumLength = CarBrandMinLength, ErrorMessage = LengthMessage)]
        public string Brand { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireMessage)]
        [StringLength(CarModelMaxLength, MinimumLength = CarModelMinLength, ErrorMessage = LengthMessage)]
        public string Model { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireMessage)]
        [DisplayName("Price per day")]
        public int PricePerDay { get; set; }

        [StringLength(CarDescriptionMaxLength, MinimumLength = CarDescriptionMinLength, ErrorMessage = LengthMessage)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireMessage)]
        [DisplayName("Image URL")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireMessage)]
        public Transmission Transmission { get; set; }

        [Required(ErrorMessage = RequireMessage)]
        public Fuel Fuel { get; set; }

        [DisplayName("Is the vehicle Rented")]
        public bool IsRented { get; set; }
    }
}