using E_learning.Model;
using E_learning.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class Lop_Thi_KiemTraController : ControllerBase
    {
        private readonly ILogger<Lop_Thi_KiemTraController> _logger;
        private Lop_Thi_KiemTraService _KTService;

        public Lop_Thi_KiemTraController(ILogger<Lop_Thi_KiemTraController> logger, Lop_Thi_KiemTraService KTService)
        {
            _logger = logger;
            _KTService = KTService;
        }

        [HttpGet]
        public async Task<ActionResult> GetLop_Thi_KiemTra ()
        {
            try
            {
                var listLop_Thi_KiemTra = _KTService.GetLop_Thi_KiemTras();
                return Ok(new { result = true, data = listLop_Thi_KiemTra });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET Lop_Thi_KiemTra !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1Lop_Thi_KiemTra(Lop_Thi_KiemTraModel newKT)
        {
            try
            {
                _KTService.InsertLop_Thi_KiemTra(newKT);
                return Ok(new { result = true, message = "Insert Lop_Thi_KiemTra Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert Lop_Thi_KiemTra Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1Lop_Thi_KiemTra(Guid ID_Lop_Thi_KiemTra, Lop_Thi_KiemTraModel newKT)
        {
            try
            {
                _KTService.UpdateLop_Thi_KiemTra(ID_Lop_Thi_KiemTra, newKT);
                return Ok(new { result = true, message = "Update Lop_Thi_KiemTra Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update Lop_Thi_KiemTra Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1Lop_Thi_KiemTra(Guid ID_Lop_Thi_KiemTra)
        {
            try
            {
                _KTService.RemoveLop_Thi_KiemTra(ID_Lop_Thi_KiemTra);
                return Ok(new { result = true, message = "Delete Lop_Thi_KiemTra Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete Lop_Thi_KiemTra Failed !" });
            }
        }

    }
}
