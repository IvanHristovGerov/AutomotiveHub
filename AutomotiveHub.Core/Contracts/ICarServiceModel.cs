using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveHub.Core.Contracts
{
    public interface ICarServiceModel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int PricePerDay { get; set; }
    }
}
