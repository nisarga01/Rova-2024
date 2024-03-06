using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rova_2024.IServices;

namespace Rova_2024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        public readonly ISellerCommercialDetailsServices sellerCommercialDetailsServices;
        public SellerController(ISellerCommercialDetailsServices sellerCommercialDetailsServices)
        {
            this.sellerCommercialDetailsServices = sellerCommercialDetailsServices;
        }
       
    }
}
