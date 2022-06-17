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
    public class LopController : ControllerBase
    {
        private readonly ILogger<LopController> _logger;
        private LopService _lopService;
        private readonly UserManager<AspNetUser> _userManager;

        public LopController(ILogger<LopController> logger, LopService lopService, UserManager<AspNetUser> userManager)
        {
            _logger = logger;
            _lopService = lopService;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<ActionResult> GetLop()
        {
            try
            {
                var listLop = _lopService.GetLops();

                return Ok(new { result = true, data = listLop });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET Lop !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1Lop(LopModel newLop)
        {
            try
            {
                 
                _lopService.InsertLop(newLop, _userManager);

                return Ok(new { result = true, message = "Insert Lop Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert Lop Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1Lop(Guid ID_Lop, LopModel newLop)
        {
            try
            {
                _lopService.UpdateLop(ID_Lop, newLop, _userManager);
                return Ok(new { result = true, message = "Update Lop Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update Lop Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1Lop(Guid ID_Lop)
        {
            try
            {
                _lopService.RemoveLop(ID_Lop);
                return Ok(new { result = true, message = "Delete Lop Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete Lop Failed !" });
            }
        }

    }
}
