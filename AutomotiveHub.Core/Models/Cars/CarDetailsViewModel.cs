using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveHub.Core.Models.Cars
{
    public class CarDetailsViewModel
    {
        public int Id { get; init; }

        public string Brand { get; init; } = string.Empty;

        public string Model { get; init; } = string.Empty;

        public string ImageUrl { get; init; } = string.Empty;

        public string Category { get; init; } = string.Empty;
    }
}
