using AutomotiveHub.Core.Models.Dealer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveHub.Core.Models.Cars
{
    public class CarDetailsServiceModel : CarServiceModel
    {
        [DisplayName("Year of production")]
        public int Year { get; set; }

        public string Category { get; set; } = string.Empty;

        public DealerQueryModel Dealer { get; set; } = null!;
    }
}
