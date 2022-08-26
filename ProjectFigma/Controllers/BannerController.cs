using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectFigma.Data;
using ProjectFigma.Response;

namespace ProjectFigma.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class BannerController : ControllerBase
    {
        private readonly VLUDataDbContext _vluData;

        public BannerController(VLUDataDbContext vluData)
        {
            _vluData = vluData;
        }
        
        [EnableCors("AllowOrigin")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var banner = _vluData.BannerDatas.ToList();
            if (banner != null)
            {
                return Ok(new ApiResponse
                {
                    Success = "Success",
                    Data = banner
                }) ;
           
            }
            return BadRequest();
            
        }
    }
}
