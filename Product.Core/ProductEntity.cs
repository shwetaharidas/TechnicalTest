using System.ComponentModel.DataAnnotations;

namespace Product.Core
{
    public class ProductEntity
    {
        [Key]
        public string Sku { get; set; }
        public string Style { get; set; }

        public string Colour { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }
    }
}
