using E_learning.Entity;
using E_learning.Model;
using E_learning.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThoiKhoaBieuController : ControllerBase
    {
        private readonly ILogger<ThoiKhoaBieuController> _logger;
        private ThoiKhoaBieuService _ThoiKhoaBieuService;

        public ThoiKhoaBieuController(ILogger<ThoiKhoaBieuController> logger, ThoiKhoaBieuService ThoiKhoaBieuService)
        {
            _logger = logger;
            _ThoiKhoaBieuService = ThoiKhoaBieuService;
        }

        [HttpGet]
        public async Task<ActionResult> GetThoiKhoaBieu()
        {
            try
            {
                var listThoiKhoaBieu = _ThoiKhoaBieuService.GetThoiKhoaBieus();
                return Ok(new { result = true, data = listThoiKhoaBieu });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET ThoiKhoaBieu !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1ThoiKhoaBieu(ThoiKhoaBieuModel newThoiKhoaBieu)
        {
            try
            {
                 
                _ThoiKhoaBieuService.InsertThoiKhoaBieu(newThoiKhoaBieu);

                return Ok(new { result = true, message = "Insert ThoiKhoaBieu Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert ThoiKhoaBieu Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1ThoiKhoaBieu(Guid ID, ThoiKhoaBieuModel newThoiKhoaBieu)
        {
            try
            {
                _ThoiKhoaBieuService.UpdateThoiKhoaBieu(ID, newThoiKhoaBieu);
                return Ok(new { result = true, message = "Update ThoiKhoaBieu Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update ThoiKhoaBieu Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1ThoiKhoaBieu(Guid ID)
        {
            try
            {
                _ThoiKhoaBieuService.RemoveThoiKhoaBieu(ID);
                return Ok(new { result = true, message = "Delete ThoiKhoaBieu Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete ThoiKhoaBieu Failed !" });
            }
        }

    }
}
