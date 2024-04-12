using AutomotiveHub.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveHub.Core.Models.Admin
{
    public class AllRentsModel
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public int ReservationPeriodId { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Price { get; set; }

        public bool IsActive { get; set; }
    }
}
