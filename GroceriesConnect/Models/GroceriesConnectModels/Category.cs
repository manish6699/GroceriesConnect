using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GroceriesConnect.Models.GroceriesConnectModels
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please select valid category")]
        [Display(Name = "Category Name")]
        [MaxLength(128)]
        public string CategoryName { get; set; }

        public List<Category> Categories { get; set; }
    }
}