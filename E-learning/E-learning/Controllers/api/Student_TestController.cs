using E_learning.DTO;
using E_learning.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class Student_TestController : ControllerBase
    {
        private readonly ILogger<Student_TestController> _logger;
        private Student_TestService _Student_TestService;

        public Student_TestController(ILogger<Student_TestController> logger, Student_TestService Student_TestService)
        {
            _logger = logger;
            _Student_TestService = Student_TestService;
        }

        [HttpGet]
        public async Task<ActionResult> GetStudent_Test ()
        {
            try
            {
                var listStudent_Test = _Student_TestService.GetStudent_Tests();
                return Ok(new { result = true, data = listStudent_Test });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET Student_Test !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1Student_Test(Student_TestDTO newStudent_Test)
        {
            try
            {
                _Student_TestService.InsertStudent_Test(newStudent_Test);
                return Ok(new { result = true, message = "Insert Student_Test Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert Student_Test Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1Student_Test(Student_TestDTO newStudent_Test)
        {
            try
            {
                _Student_TestService.UpdateStudent_Test(newStudent_Test);
                return Ok(new { result = true, message = "Update Student_Test Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update Student_Test Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1Student_Test(string ID_Student, string ID_Class_Test)
        {
            try
            {
                _Student_TestService.RemoveStudent_Test(ID_Student, ID_Class_Test);
                return Ok(new { result = true, message = "Delete Student_Test Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete Student_Test Failed !" });
            }
        }
    }
}
