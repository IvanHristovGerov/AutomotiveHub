using AutomotiveHub.Core.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomotiveHub.Core.Constants.MessageConstants;
using static AutomotiveHub.Infrastructure.Constants.DataConstants;
using AutomotiveHub.Infrastructure.Enumerations;

namespace AutomotiveHub.Core.Models.Cars
{
    public class CarFormModel : ICarServiceModel
    {
        [Required(ErrorMessage = RequireMessage)]
        [StringLength(CarBrandMaxLength, MinimumLength = CarBrandMinLength, ErrorMessage = LengthMessage)]
        public string Brand { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireMessage)]
        [StringLength(CarModelMaxLength, MinimumLength = CarModelMinLength, ErrorMessage = LengthMessage)]
        public string Model { get; set; } = string.Empty;

        [Required(ErrorMessage = YearOfProductionMessage)]
        [Range(CarYearMinValue, CarYearMaxValue)]
        public int Year { get; set; }

        [Required]
        [Range(CarKilometersMinValue, CarKilometersMaxValue)]
        public int Kilometers { get; set; }

        [Required(ErrorMessage = PricePerDayMessage)]
        [Range(PricePerDayMinValue, PricePerDayMaxValue)]
        [DisplayName("Price per day")]
        public int PricePerDay { get; set; }

        [Required(ErrorMessage = RequireMessage)]
        [DisplayName("Image URL")]
        public string ImageUrl { get; set; } = string.Empty;

        [StringLength(CarDescriptionMaxLength, MinimumLength = CarDescriptionMinLength, ErrorMessage = LengthMessage)]
        public string Description { get; set; } = string.Empty;


        [Required(ErrorMessage = RequireMessage)]
        public Transmission Transmission { get; set; }

        [Required(ErrorMessage = RequireMessage)]
        public Fuel Fuel { get; set; }

        [Required]
        [DisplayName("Category")]
        public int CategoryId { get; set; }

        public IEnumerable<CarCategoryServiceModel> Categories { get; set; }=new List<CarCategoryServiceModel>();
    }
}
