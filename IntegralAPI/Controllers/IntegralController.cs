using IntegralAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntegralAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IntegralController : Controller
    {
        [HttpGet("calculateIntegral")]
        public async Task<ActionResult<double>> CalculateIntegral(int SplitNumbers, double UpLim, double LowLim)
        {
            try
            {
                SimsonMethod simsonMethod = new SimsonMethod(SplitNumbers, UpLim, LowLim);
                simsonMethod.Calculate();
                return simsonMethod.res;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
