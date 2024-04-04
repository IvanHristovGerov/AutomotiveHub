﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveHub.Core.Models.Dealer
{
    public class DealerQueryModel
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Phone]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; } = string.Empty;


    }
}
