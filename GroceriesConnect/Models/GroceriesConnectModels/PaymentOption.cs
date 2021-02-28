using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GroceriesConnect.Models.GroceriesConnectModels
{
    public class PaymentOption
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(128)]
        [Required]
        public string PaymentMode { get; set; }
    }
}