using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectFigma.Data;
using ProjectFigma.Response;

namespace ProjectFigma.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DescribeInWordController : ControllerBase
    {
        private readonly VLUDataDbContext _vLUDataDb;

        public DescribeInWordController(VLUDataDbContext vLUDataDb)
        {
            _vLUDataDb = vLUDataDb;
        }
        [EnableCors("AllowOrigin")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var DescribeInWord = _vLUDataDb.DescribeInWordDatas.ToList();
            if (DescribeInWord != null)
            {
                return Ok(new ApiResponse
                {
                    Success = "Success",
                    Data = DescribeInWord
                });

            }
            return BadRequest();
        }
    }
}
