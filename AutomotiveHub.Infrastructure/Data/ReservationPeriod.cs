using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AutomotiveHub.Infrastructure.Data
{
    public class ReservationPeriod
    {
        [Key]
        [Comment("ReservationPeriod identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Total days of the reservation")]
        public int Days { get; set; }
    }
}