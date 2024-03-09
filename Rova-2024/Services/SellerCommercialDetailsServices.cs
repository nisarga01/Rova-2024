using Microsoft.AspNetCore.Hosting;
using Rova_2024.DTO.SellerCommercialDetailsDTO;
using Rova_2024.IRepository;
using Rova_2024.IServices;
using Rova_2024.Models;
using Rova_2024.Repository;
using Rova_2024.ServiceResponse;

namespace Rova_2024.Services
{
    public class SellerCommercialDetailsServices : ISellerCommercialDetailsServices
    {
        public readonly ISellerCommercialDetailsRepository sellerCommercialDetailsRepository;
        public readonly IWebHostEnvironment webHostEnvironment;
        public SellerCommercialDetailsServices(ISellerCommercialDetailsRepository sellerCommercialDetailsRepository, IWebHostEnvironment webHostEnvironment)
        {
            this.sellerCommercialDetailsRepository = sellerCommercialDetailsRepository;
            this.webHostEnvironment = webHostEnvironment;
        }
        public async Task<ServiceResponse<SellerCommercialDetailsResponseDTO>> addSellerCommercialDetailsAsync(SellerCommercialDetailsRequestDTO sellerCommercialDetailsRequestDTO)
        {
            string documents = HandleFileUpload(sellerCommercialDetailsRequestDTO.PAN_Documnet);
            var sellerCommercialDetails = new SellerCommercialDetails
            {
                GST_Number = sellerCommercialDetailsRequestDTO.GST_Number,
                PAN_Number = sellerCommercialDetailsRequestDTO.PAN_Number,
                PAN_Document = documents,
                StoreName = sellerCommercialDetailsRequestDTO.StoreName,
                City = sellerCommercialDetailsRequestDTO.City,
                Pincode = sellerCommercialDetailsRequestDTO.Pincode,
                State = sellerCommercialDetailsRequestDTO.State,
                Area = sellerCommercialDetailsRequestDTO.Area,
            };
            var Result = await sellerCommercialDetailsRepository.addSellerCommercialDetailsAsync(sellerCommercialDetails);

            var Response = new ServiceResponse<SellerCommercialDetailsResponseDTO>()
            {
                Data = Result != null && Result.Success && Result.Data != null ? new SellerCommercialDetailsResponseDTO()
                {
                    Id = Result.Data.Id,
                    //Seller_Id = Result.Data.Seller_Id,
                    GST_Number = Result.Data.GST_Number,
                    PAN_Number= Result.Data.PAN_Number,
                    PAN_Documnet = Result.Data.PAN_Document,
                    StoreName = Result.Data.StoreName,
                    City = Result.Data.City,
                    Pincode = Result.Data.Pincode,
                    State = Result.Data.State,
                    Area = Result.Data.Area,
                } : null,
                Success = Result.Success,
                ErrorMessage = Result.ErrorMessage,
                ResultMessage = Result.ResultMessage
            };
            return Response;
        }


        public string HandleFileUpload(IFormFile document)
        {
            if (document == null || document.Length == 0)
            {
                return null;
            }

            //    // Define a folder path to store the photos
            var currentDirectory = Directory.GetCurrentDirectory();
            var uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "PAN_Documnet");

            //    // Create the folder if it doesn't exist
            if (!Directory.Exists(uploadFolder))
            {
                Directory.CreateDirectory(uploadFolder);
            }

            //    // Generate a unique filename for the photo
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(document.FileName);
            var filePath = Path.Combine(uploadFolder, fileName);

            //    // Save the photo to the file system
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                document.CopyTo(fileStream);
            }

            //    // Return the URL of the saved photo
            return "/PAN_Document/" + fileName; // Adjust this based on your project's URL structure
        }

    }
}
