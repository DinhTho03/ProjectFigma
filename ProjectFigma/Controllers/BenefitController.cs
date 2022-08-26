using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectFigma.Data;
using ProjectFigma.Response;

namespace ProjectFigma.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BenefitController : ControllerBase
    {
        private readonly VLUDataDbContext _vLuDataDb;

        public BenefitController(VLUDataDbContext vLUDataDb)
        {
            _vLuDataDb = vLUDataDb;
        }
        [EnableCors("AllowOrigin")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var Benefit = _vLuDataDb.BenefitDatas.ToList();
            if (Benefit != null)
            {
                return Ok(new ApiResponse
                {
                    Success = "Success",
                    Data = Benefit
                });

            }
            return StatusCode(StatusCodes.Status500InternalServerError);
                
        }
    }
}
