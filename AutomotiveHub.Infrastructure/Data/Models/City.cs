﻿using AutomotiveHub.Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AutomotiveHub.Infrastructure.Data.Models
{
    public class City
    {
        [Key]
        [Comment("City identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataConstants.CityNameMaxLength)]
        [Comment("City name")]
        public string Name { get; set; } = string.Empty;

        public IEnumerable<Dealership> Dealerships { get; set; } = new List<Dealership>();
    }
}
