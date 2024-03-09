﻿using Rova_2024.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rova_2024.DTO.SellerCommercialDetailsDTO
{
    public class SellerCommercialDetailsResponseDTO
    {
        public int Id { get; set; }
        //public int Seller_Id { get; set; }
        public int GST_Number { get; set; }
        public int PAN_Number { get; set; }
        public string? PAN_Documnet { get; set; }
        public string StoreName { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }
        public string State { get; set; }
        public string Area { get; set; }

    }
}