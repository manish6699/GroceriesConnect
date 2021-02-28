using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GroceriesConnect.Models.GroceriesConnectModels
{
    public class PickupOption
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(128)]
        [Required]
        public string OptionName { get; set; }

        public List<Order> Orders { get; set; }
    }
}