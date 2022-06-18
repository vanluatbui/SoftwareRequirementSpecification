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
    public class Lop_HocSinhController : ControllerBase
    {
        private readonly ILogger<Lop_HocSinhController> _logger;
        private Lop_HocSinhService _lop_HocSinhService;

        public Lop_HocSinhController(ILogger<Lop_HocSinhController> logger, Lop_HocSinhService lop_HocSinhService)
        {
            _logger = logger;
            _lop_HocSinhService = lop_HocSinhService;
        }

        [HttpGet]
        public async Task<ActionResult> GetLop_HocSinh()
        {
            try
            {
                var listLop_HocSinh = _lop_HocSinhService.GetLop_HocSinhs();
                return Ok(new { result = true, data = listLop_HocSinh });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET Lop_HocSinh !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1Lop_HocSinh(Lop_HocSinhModel newLop_HocSinh)
        {
            try
            {
                 
                _lop_HocSinhService.InsertLop_HocSinh(newLop_HocSinh);

                return Ok(new { result = true, message = "Insert Lop_HocSinh Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert Lop_HocSinh Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1Lop_HocSinh(Guid ID, Lop_HocSinhModel newLop_HocSinh)
        {
            try
            {
                _lop_HocSinhService.UpdateLop_HocSinh(ID, newLop_HocSinh);
                return Ok(new { result = true, message = "Update Lop_HocSinh Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update Lop_HocSinh Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1Lop_HocSinh(Guid ID)
        {
            try
            {
                _lop_HocSinhService.RemoveLop_HocSinh(ID);
                return Ok(new { result = true, message = "Delete Lop_HocSinh Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete Lop_HocSinh Failed !" });
            }
        }

    }
}
