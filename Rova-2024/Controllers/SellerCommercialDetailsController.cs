using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rova_2024.DTO.SellerCommercialDetailsDTO;
using Rova_2024.IServices;

namespace Rova_2024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerCommercialDetailsController : ControllerBase
    {
        public readonly ISellerCommercialDetailsServices sellerCommercialDetailsServices;
        public SellerCommercialDetailsController(ISellerCommercialDetailsServices sellerCommercialDetailsServices)
        {
            this.sellerCommercialDetailsServices = sellerCommercialDetailsServices;
        }

        [EnableCors("CORSPolicy")]
        [HttpPost("addSellerCommercialDetails")]
        public async Task<IActionResult> addSellerCommercialDetailsAsync([FromForm] SellerCommercialDetailsRequestDTO sellerdetails)
        {
            var Result = await sellerCommercialDetailsServices.addSellerCommercialDetailsAsync(sellerdetails);
            if (Result.Success)
                return Ok(Result);
            return BadRequest();
        }

    }
}
