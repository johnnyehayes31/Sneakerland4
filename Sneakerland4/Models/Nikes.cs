using System.ComponentModel.DataAnnotations;

namespace Sneakerland4.Data 
{
    public class Nikes
    {
        [Key]
        public int NikeId { get; set; }

        public string? NikeName { get; set; }
        public string? NikeClothing { get; set; }
        public string? NikeShoes { get; set; }
    }
}
