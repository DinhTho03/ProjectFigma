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
    public class FilterController : ControllerBase
    {
        private readonly VLUDataDbContext _vluData;

        public FilterController(VLUDataDbContext vLuData)
        {
            _vluData = vLuData;
        }
        [EnableCors("AllowOrigin")]
        [HttpGet]
        public IActionResult GetAll()
        {

            var searchInfo = _vluData.FilterDatas.ToList();

            if (searchInfo != null)
            {
                return Ok(new ApiResponse
                {
                    Success = "Success",
                    Data = searchInfo
                });

            }
            return NotFound();
            
        }
    }
}
