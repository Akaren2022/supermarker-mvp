﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class CategoriesModel
    {
        [DisplayName("Pay Mode Id")]
        public int Id { get; set; }
        [DisplayName("Pay Mode Name")]
        [Required(ErrorMessage = "Pay Mode name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pay Mode name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Observation")]
        [Required(ErrorMessage = "Pay mode observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Pay mode observation must be between 3 and 200 characters")]
        public string Observation { get; set; }
    }
}