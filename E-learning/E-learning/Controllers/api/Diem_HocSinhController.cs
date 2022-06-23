using E_learning.Model;
using E_learning.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class Diem_HocSinhController : ControllerBase
    {
        private readonly ILogger<Diem_HocSinhController> _logger;
        private Diem_HocSinhService _kqService;

        public Diem_HocSinhController(ILogger<Diem_HocSinhController> logger, Diem_HocSinhService kqService)
        {
            _logger = logger;
            _kqService = kqService;
        }

        [HttpGet]
        public async Task<ActionResult> GetDiem_HocSinh ()
        {
            try
            {
                var listDiem_HocSinh = _kqService.GetDiem_HocSinhs();
                return Ok(new { result = true, data = listDiem_HocSinh });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET Diem_HocSinh !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1Diem_HocSinh(Diem_HocSinhModel newKQ)
        {
            try
            {
                _kqService.InsertDiem_HocSinh(newKQ);
                return Ok(new { result = true, message = "Insert Diem_HocSinh Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert Diem_HocSinh Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1Diem_HocSinh(Guid ID_Diem_HocSinh, Diem_HocSinhModel newKQ)
        {
            try
            {
                _kqService.UpdateDiem_HocSinh(ID_Diem_HocSinh, newKQ);
                return Ok(new { result = true, message = "Update Diem_HocSinh Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update Diem_HocSinh Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1Diem_HocSinh(Guid ID_Diem_HocSinh)
        {
            try
            {
                _kqService.RemoveDiem_HocSinh(ID_Diem_HocSinh);
                return Ok(new { result = true, message = "Delete Diem_HocSinh Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete Diem_HocSinh Failed !" });
            }
        }

    }
}
