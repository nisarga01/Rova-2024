using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Rova_2024.Models
{
    // Created this table for testing
    public class Sellers
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int SellerId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public SellerCommercialDetails CommercialDetails { get; set; } // Navigation property
    }
}
