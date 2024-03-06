using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Rova_2024.Models
{
    public class Sellers
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int SellerId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int OTP { get; set; }
        public bool IsOTPVerified { get; set; } = false;
    }
}
