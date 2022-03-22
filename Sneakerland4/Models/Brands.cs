using System.ComponentModel.DataAnnotations;
using System;

namespace Sneakerland4.Data
{
    public class Brands
    {
        [Key]
        public int BrandsId { get; set; }
        public string? BrandsName { get; set; }
        public string? BrandsDescription { get; set; }
        public int BrandsCount { get; set; }

        float BrandPrice { get; set; }
    }
}
