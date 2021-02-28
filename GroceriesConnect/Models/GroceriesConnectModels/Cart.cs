using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GroceriesConnect.Models.GroceriesConnectModels
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(128)]
        [ForeignKey("Customers")]
        public string CustomerId { get; set; }
        public ApplicationUser Customers { get; set; }

        [MaxLength(128)]
        [ForeignKey("Vendors")]
        public string VendorId { get; set; }
        public ApplicationUser Vendors { get; set; }

        public int TotalPrice { get; set; }
    }
}