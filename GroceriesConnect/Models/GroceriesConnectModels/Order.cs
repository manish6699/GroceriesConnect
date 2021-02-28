using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GroceriesConnect.Models.GroceriesConnectModels
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Cart")]
        public int CartId { get; set; }
        public Cart Cart { get; set; }

        [ForeignKey("PickupMode")]
        public int PickupId { get; set; }
        public PickupOption PickupMode { get; set; }

        [ForeignKey("PaymentMode")]
        public int PaymentId { get; set; }
        public PaymentOption PaymentMode { get; set; }

        [Required]
        [ForeignKey("Vendor")]
        public string VendorId { get; set; }
        public ApplicationUser Vendor { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime TimeStamp { get; set; }
    }
}