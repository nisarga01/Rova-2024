namespace Rova_2024.DTO.SellerCommercialDetailsDTO
{
    public class SellerCommercialDetailsRequestDTO
    {
        public int GST_Number { get; set; }
        public int PAN_Number { get; set; }
        public IFormFile? PAN_Documnet { get; set; }
        public string StoreName { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }
        public string State { get; set; }
        public string Area { get; set; }
    }
}
