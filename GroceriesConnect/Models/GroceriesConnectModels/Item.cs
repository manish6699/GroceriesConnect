using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GroceriesConnect.Models.GroceriesConnectModels
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Catalog")]
        public int CatalogId { get; set; }

        public Catalog Catalog { get; set; }

        [Required(ErrorMessage = "Please enter item name")]
        [MaxLength(128)]
        public string ItemName { get; set; }

        [Required(ErrorMessage = "Please enter item price")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Please enter available stocks")]
        [Display(Name = "Stocks Available")]
        public int StocksAvailable { get; set; }

        public List<ItemDetail> ItemDetails { get; set; }
    }
}