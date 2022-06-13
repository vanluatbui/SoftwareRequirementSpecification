using E_learning.Model;
using E_learning.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhoaHocController : ControllerBase
    {
        private readonly ILogger<KhoaHocController> _logger;
        private KhoaHocService _khService;

        public KhoaHocController(ILogger<KhoaHocController> logger, KhoaHocService khService)
        {
            _logger = logger;
            _khService = khService;
        }

        [HttpGet]
        public async Task<ActionResult> GetKhoaHoc ()
        {
            try
            {
                var listKhoaHoc = _khService.GetKhoaHocs();
                return Ok(new { result = true, data = listKhoaHoc });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET KhoaHoc !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1KhoaHoc(KhoaHocModel newKH)
        {
            try
            {
                _khService.InsertKhoaHoc(newKH);
                return Ok(new { result = true, message = "Insert KhoaHoc Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert KhoaHoc Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1KhoaHoc(Guid ID_KhoaHoc, KhoaHocModel newKH)
        {
            try
            {
                _khService.UpdateKhoaHoc(ID_KhoaHoc, newKH);
                return Ok(new { result = true, message = "Update KhoaHoc Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update KhoaHoc Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1KhoaHoc(Guid ID_KhoaHoc)
        {
            try
            {
                _khService.RemoveKhoaHoc(ID_KhoaHoc);
                return Ok(new { result = true, message = "Delete KhoaHoc Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete KhoaHoc Failed !" });
            }
        }

    }
}
