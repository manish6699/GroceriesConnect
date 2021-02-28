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
        [ForeignKey("Customer")]
        public string CustomerId { get; set; }
        public ApplicationUser Customer { get; set; }

        public int TotalPrice { get; set; }

        public List<ItemDetail> ItemDetails { get; set; }
    }
}