﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Rova_2024.Models
{
    public class SellersCommercialDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int Seller_Id { get; set; }
        public int GST_Number { get; set; }
        public int PAN_Number { get; set; }
        public string PAN_Documnet { get; set; }
        public string StoreName { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }
        public string State { get; set; }
        public string Area { get; set; }

        [ForeignKey("SellerId")]
        public virtual Sellers Seller { get; set; }

    }
}