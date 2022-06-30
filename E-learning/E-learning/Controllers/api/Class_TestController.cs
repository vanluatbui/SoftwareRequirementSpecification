using E_learning.DTO;
using E_learning.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class Class_TestController : ControllerBase
    {
        private readonly ILogger<Class_TestController> _logger;
        private Class_TestService _Class_TestService;

        public Class_TestController(ILogger<Class_TestController> logger, Class_TestService Class_TestService)
        {
            _logger = logger;
            _Class_TestService = Class_TestService;
        }

        [HttpGet]
        public async Task<ActionResult> GetClass_Test ()
        {
            try
            {
                var listClass_Test = _Class_TestService.GetClass_Tests();
                return Ok(new { result = true, data = listClass_Test });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET Class_Test !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1Class_Test(Class_TestDTO newClass_Test)
        {
            try
            {
                _Class_TestService.InsertClass_Test(newClass_Test);
                return Ok(new { result = true, message = "Insert Class_Test Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert Class_Test Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1Class_Test(Class_TestDTO newClass_Test)
        {
            try
            {
                _Class_TestService.UpdateClass_Test(newClass_Test);
                return Ok(new { result = true, message = "Update Class_Test Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update Class_Test Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1Class_Test(string ID_Class_Test)
        {
            try
            {
                _Class_TestService.RemoveClass_Test(ID_Class_Test);
                return Ok(new { result = true, message = "Delete Class_Test Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete Class_Test Failed !" });
            }
        }
    }
}
