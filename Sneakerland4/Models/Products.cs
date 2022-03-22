using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sneakerland4.Data
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string? ProductName { get; set; }

        public double ProductPrice { get; set; }

        public string? ProductDescription { get; set; }

        [ForeignKey("BrandID")]
        public int BrandId { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
    }
}
