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
    public class Lop_MonHocController : ControllerBase
    {
        private readonly ILogger<Lop_MonHocController> _logger;
        private Lop_MonHocService _Lop_MonHocService;
        private readonly UserManager<AspNetUser> _userManager;

        public Lop_MonHocController(ILogger<Lop_MonHocController> logger, Lop_MonHocService Lop_MonHocService, UserManager<AspNetUser> userManager)
        {
            _logger = logger;
            _Lop_MonHocService = Lop_MonHocService;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<ActionResult> GetLop_MonHoc()
        {
            try
            {
                var listLop_MonHoc = _Lop_MonHocService.GetLop_MonHocs();
                return Ok(new { result = true, data = listLop_MonHoc });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET Lop_MonHoc !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1Lop_MonHoc(Lop_MonHocModel newLop_MonHoc)
        {
            try
            {
                 
                _Lop_MonHocService.InsertLop_MonHoc(newLop_MonHoc, _userManager);

                return Ok(new { result = true, message = "Insert Lop_MonHoc Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert Lop_MonHoc Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1Lop_MonHoc(Guid ID, Lop_MonHocModel newLop_MonHoc)
        {
            try
            {
                _Lop_MonHocService.UpdateLop_MonHoc(ID, newLop_MonHoc, _userManager);
                return Ok(new { result = true, message = "Update Lop_MonHoc Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update Lop_MonHoc Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1Lop_MonHoc(Guid ID)
        {
            try
            {
                _Lop_MonHocService.RemoveLop_MonHoc(ID);
                return Ok(new { result = true, message = "Delete Lop_MonHoc Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete Lop_MonHoc Failed !" });
            }
        }

    }
}
