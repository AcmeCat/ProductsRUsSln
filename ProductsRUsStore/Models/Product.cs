using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsRUsStore.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { set; get; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        public string Image { set; get; }
    }
}
