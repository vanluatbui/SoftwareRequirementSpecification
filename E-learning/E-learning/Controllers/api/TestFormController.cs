using E_learning.DTO;
using E_learning.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestFormController : ControllerBase
    {
        private readonly ILogger<TestFormController> _logger;
        private TestFormService _TestFormService;

        public TestFormController(ILogger<TestFormController> logger, TestFormService TestFormService)
        {
            _logger = logger;
            _TestFormService = TestFormService;
        }

        [HttpGet]
        public async Task<ActionResult> GetTestForm ()
        {
            try
            {
                var listTestForm = _TestFormService.GetTestForms();
                return Ok(new { result = true, data = listTestForm });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET TestForm !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1TestForm(TestFormDTO newTestForm)
        {
            try
            {
                _TestFormService.InsertTestForm(newTestForm);
                return Ok(new { result = true, message = "Insert TestForm Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert TestForm Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1TestForm(TestFormDTO newTestForm)
        {
            try
            {
                _TestFormService.UpdateTestForm(newTestForm);
                return Ok(new { result = true, message = "Update TestForm Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update TestForm Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1TestForm(string ID_TestForm)
        {
            try
            {
                _TestFormService.RemoveTestForm(ID_TestForm);
                return Ok(new { result = true, message = "Delete TestForm Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete TestForm Failed !" });
            }
        }
    }
}
