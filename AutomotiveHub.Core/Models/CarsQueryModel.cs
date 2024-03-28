using AutomotiveHub.Core.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveHub.Core.Models
{
    public class CarsQueryModel
    {
        public int CarsPerPage { get; } = 3;

        public string Category { get; set; } = string.Empty;

        public int CurrentPage { get; set; } = 1;

        public int TotalCarsCount { get; set; }

        [DisplayName("Search by text")]
        public string SearchQuery { get; set; } = string.Empty;

        public CarSorting Sorting { get; set; }

        public IEnumerable<string> Categories { get; set; } = null!;
        public IEnumerable<CarServiceModel> Cars { get; set; } = new List<CarServiceModel>();
    }
}
