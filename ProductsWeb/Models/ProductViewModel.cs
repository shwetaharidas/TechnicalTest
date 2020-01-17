using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductsWeb.Models
{
    public class ProductViewModel
    {
        [Remote("SkuExist", "Products", ErrorMessage = "Sku already exists")]
        public string Sku { get; set; }

        [Required]
        public string Style { get; set; }

        [Required]
        public string Colour { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Stock { get; set; }

    }
}