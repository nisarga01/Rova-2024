using Rova_2024.Data;
using Rova_2024.IRepository;
using Rova_2024.Models;
using Rova_2024.ServiceResponse;

namespace Rova_2024.Repository
{
    public class SellerCommercialDetailsRepository : ISellerCommercialDetailsRepository
    {
        public readonly RovaDBContext dbContext;
        public SellerCommercialDetailsRepository(RovaDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<ServiceResponse<SellerCommercialDetails>> addSellerCommercialDetailsAsync(SellerCommercialDetails sellersCommercialDetails)
        {
            try
            {
                await dbContext.SellerCommercialDetails.AddAsync(sellersCommercialDetails);
                await dbContext.SaveChangesAsync();
                return new ServiceResponse<SellerCommercialDetails>()
                {
                    Data=sellersCommercialDetails,
                    Success = true,
                    ResultMessage = "Sellers Commercial Details Added Successfully"
                    
                };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<SellerCommercialDetails>()
                {
                    Success = false,
                    ResultMessage = ex.Message,
                    //ErrorMessage = "Error occured while adding Seller commercial details! try again"
                };
            }


        }

    }
}
