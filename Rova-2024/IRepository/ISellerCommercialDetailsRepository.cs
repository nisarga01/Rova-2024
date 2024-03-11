﻿using Rova_2024.Models;
using Rova_2024.ServiceResponse;

namespace Rova_2024.IRepository
{
    public interface ISellerCommercialDetailsRepository
    {
        Task<Sellers> GetSellerIdByPhoneAsync(string phone);
        Task<ServiceResponse<SellerCommercialDetails>> addSellerCommercialDetailsAsync(SellerCommercialDetails sellersCommercialDetails);
    }
}
