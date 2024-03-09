using Rova_2024.DTO.SellerCommercialDetailsDTO;
using Rova_2024.ServiceResponse;

namespace Rova_2024.IServices
{
    public interface ISellerCommercialDetailsServices
    {
        Task<ServiceResponse<SellerCommercialDetailsResponseDTO>> addSellerCommercialDetailsAsync(SellerCommercialDetailsRequestDTO request);
    }
}
