using E_learning.Model;
using E_learning.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonHocController : ControllerBase
    {
        private readonly ILogger<MonHocController> _logger;
        private MonHocService _mhService;

        public MonHocController(ILogger<MonHocController> logger, MonHocService mhService)
        {
            _logger = logger;
            _mhService = mhService;
        }

        [HttpGet]
        public async Task<ActionResult> GetMonHoc ()
        {
            try
            {
                var listMonHoc = _mhService.GetMonHocs();
                return Ok(new { result = true, data = listMonHoc });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET MonHoc !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1MonHoc(MonHocModel newMH)
        {
            try
            {
                _mhService.InsertMonHoc(newMH);
                return Ok(new { result = true, message = "Insert MonHoc Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert MonHoc Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1MonHoc(Guid ID_MonHoc, MonHocModel newMH)
        {
            try
            {
                _mhService.UpdateMonHoc(ID_MonHoc, newMH);
                return Ok(new { result = true, message = "Update MonHoc Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update MonHoc Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1MonHoc(Guid ID_MonHoc)
        {
            try
            {
                _mhService.RemoveMonHoc(ID_MonHoc);
                return Ok(new { result = true, message = "Delete MonHoc Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete MonHoc Failed !" });
            }
        }

    }
}
