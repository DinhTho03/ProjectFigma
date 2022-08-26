using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectFigma.Data;
using ProjectFigma.Response;
using System.Linq;

namespace ProjectFigma.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeaderController : ControllerBase
    {
        private readonly VLUDataDbContext _vluData;

        public HeaderController(VLUDataDbContext vluData)
        {
            _vluData = vluData;
        }
        [EnableCors("AllowOrigin")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var header = _vluData.Headers.ToList();
            if(header != null)
            {
                return Ok(new ApiResponse
                {
                    Success = "Success",
                    Data = header
                });

            }
            return BadRequest();
            
        }
    }
}
