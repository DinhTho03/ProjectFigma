using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectFigma.Data;
using ProjectFigma.Response;

namespace ProjectFigma.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private VLUDataDbContext _vLUData;

        public ModelController(VLUDataDbContext vLUData)
        {
            _vLUData = vLUData;
        }
        [EnableCors("AllowOrigin")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var Model = _vLUData.ModelDatas.ToList();
            if (Model != null)
            {
                return Ok(new ApiResponse
                {
                    Success = "Success",
                    Data = Model
                });

            }
            return BadRequest();
        }
    }
}
