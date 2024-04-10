using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomotiveHub.Infrastructure.Constants.DataConstants;
using static AutomotiveHub.Core.Constants.MessageConstants;
using System.ComponentModel;

namespace AutomotiveHub.Core.Models.Dealer
{
    public class AddDealershipServiceModel
    {
        [Required]
        [StringLength(DealershipNameMaxLength, MinimumLength = DealershipNameMinLength, ErrorMessage = LengthMessage)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(DealershipAddressMaxLength, MinimumLength = DealershipAddressMinLength, ErrorMessage = LengthMessage)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [DisplayName("City")]
        public int CityId { get; set; }

        public IEnumerable<AllCitiesServiceModel> Cities { get; set; } = new List<AllCitiesServiceModel>();
    }
}
