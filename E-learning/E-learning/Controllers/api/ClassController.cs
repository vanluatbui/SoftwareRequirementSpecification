using E_learning.DTO;
using E_learning.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly ILogger<ClassController> _logger;
        private ClassService _ClassService;

        public ClassController(ILogger<ClassController> logger, ClassService ClassService)
        {
            _logger = logger;
            _ClassService = ClassService;
        }

        [HttpGet]
        public async Task<ActionResult> GetClass ()
        {
            try
            {
                var listClass = _ClassService.GetClasss();
                return Ok(new { result = true, data = listClass });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET Class !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1Class(ClassDTO newClass)
        {
            try
            {
                _ClassService.InsertClass(newClass);
                return Ok(new { result = true, message = "Insert Class Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert Class Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1Class(ClassDTO newClass)
        {
            try
            {
                _ClassService.UpdateClass(newClass);
                return Ok(new { result = true, message = "Update Class Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update Class Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1Class(string ID_Class)
        {
            try
            {
                _ClassService.RemoveClass(ID_Class);
                return Ok(new { result = true, message = "Delete Class Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete Class Failed !" });
            }
        }
    }
}
