using E_learning.Model;
using E_learning.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class HinhThuc_Thi_KiemTraController : ControllerBase
    {
        private readonly ILogger<HinhThuc_Thi_KiemTraController> _logger;
        private HinhThuc_Thi_KiemTraService _htService;

        public HinhThuc_Thi_KiemTraController(ILogger<HinhThuc_Thi_KiemTraController> logger, HinhThuc_Thi_KiemTraService htService)
        {
            _logger = logger;
            _htService = htService;
        }

        [HttpGet]
        public async Task<ActionResult> GetHinhThuc_Thi_KiemTra ()
        {
            try
            {
                var listHinhThuc_Thi_KiemTra = _htService.GetHinhThuc_Thi_KiemTras();
                return Ok(new { result = true, data = listHinhThuc_Thi_KiemTra });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET HinhThuc_Thi_KiemTra !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1HinhThuc_Thi_KiemTra(HinhThuc_Thi_KiemTraModel newHT)
        {
            try
            {
                _htService.InsertHinhThuc_Thi_KiemTra(newHT);
                return Ok(new { result = true, message = "Insert HinhThuc_Thi_KiemTra Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert HinhThuc_Thi_KiemTra Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1HinhThuc_Thi_KiemTra(Guid ID_HinhThuc_Thi_KiemTra, HinhThuc_Thi_KiemTraModel newHT)
        {
            try
            {
                _htService.UpdateHinhThuc_Thi_KiemTra(ID_HinhThuc_Thi_KiemTra, newHT);
                return Ok(new { result = true, message = "Update HinhThuc_Thi_KiemTra Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update HinhThuc_Thi_KiemTra Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1HinhThuc_Thi_KiemTra(Guid ID_HinhThuc_Thi_KiemTra)
        {
            try
            {
                _htService.RemoveHinhThuc_Thi_KiemTra(ID_HinhThuc_Thi_KiemTra);
                return Ok(new { result = true, message = "Delete HinhThuc_Thi_KiemTra Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete HinhThuc_Thi_KiemTra Failed !" });
            }
        }

    }
}
