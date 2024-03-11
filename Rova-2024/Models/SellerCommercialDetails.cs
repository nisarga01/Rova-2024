using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Rova_2024.Models
{
    public class SellerCommercialDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int GST_Number { get; set; }
        public int PAN_Number { get; set; }
        public string? PAN_Document { get; set; }
        public string StoreName { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }
        public string State { get; set; }
        public string Area { get; set; }
        public Sellers Seller { get; set; } // Navigation property
    }
}

