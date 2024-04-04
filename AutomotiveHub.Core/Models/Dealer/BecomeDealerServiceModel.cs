using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomotiveHub.Core.Constants.MessageConstants;
using static AutomotiveHub.Infrastructure.Constants.DataConstants;


namespace AutomotiveHub.Core.Models.Dealer
{
    public class BecomeDealerServiceModel
    {
        [Required(ErrorMessage = RequireMessage)]
        [StringLength(DealerPhoneNumberMaxLength, MinimumLength = DealerPhoneNumberMinLength)]
        [DisplayName("Phone Number")]
        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireMessage)]
        [StringLength(DealerNameMaxLength, MinimumLength = DealerNameMinLength)]
        public string Name { get; set; } = string.Empty; 
    }
}
