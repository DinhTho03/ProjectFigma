using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectFigma.Data;
using ProjectFigma.Response;

namespace ProjectFigma.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly VLUDataDbContext _vluData;

        public DemoController(VLUDataDbContext vLUDataDbContext)
        {
            _vluData = vLUDataDbContext;
        }
        [EnableCors("AllowOrigin")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var Demo = _vluData.DemoDatas.ToList();
            if (Demo != null)
            {
                return Ok(new ApiResponse
                {
                    Success = "Success",
                    Data = Demo
                });

            }
            return StatusCode(StatusCodes.Status400BadRequest);
               
        }
        
    }
}
