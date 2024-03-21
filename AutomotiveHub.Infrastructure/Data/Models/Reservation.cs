using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomotiveHub.Infrastructure.Data.Models
{
    public class Reservation
    {
        [Key]
        [Comment("Reservation identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Start date of the reservation")]
        public DateTime StartDate { get; set; }

        [Required]
        [Comment("End date of the reservation")]
        public DateTime EndDate { get; set; }

        [Required]
        [Comment("Total price of the reservation")]
        public int TotalPrice { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public int CarId { get; set; }

        [ForeignKey(nameof(CarId))]
        public Car Car { get; set; } = null!;

        [Required]
        public int ReservationPeriodId { get; set; }

        [ForeignKey(nameof(ReservationPeriodId))]
        public ReservationPeriod ReservationPeriod { get; set; } = null!;
    }
}
