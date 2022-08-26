using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectFigma.Data;
using ProjectFigma.Response;

namespace ProjectFigma.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooterController : ControllerBase
    {
        private readonly VLUDataDbContext _vLUData;

        public FooterController(VLUDataDbContext vLUData)
        {
            _vLUData = vLUData;
        }
        [EnableCors("AllowOrigin")]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<ColumnData> columnDatas = new List<ColumnData>();
            //var ColumnList = _vLUData.ColumnDatas.ToList();
            //foreach (var Column in ColumnList)
            //{
            //    Column.columnDetailDatas = _vLUData.columnDetailDatas.Where(cl => cl.ColumnId == Column.Id).ToList();
            //}
            var ColumnList = _vLUData.ColumnDatas.Include(cl => cl.columnDetailDatas).ToList();
            if (ColumnList != null)
            {
                return Ok(new ApiResponse
                {
                    Success = "Success",
                    Data = ColumnList
                });
            }
            return StatusCode(StatusCodes.Status400BadRequest);
        }
    }
}
