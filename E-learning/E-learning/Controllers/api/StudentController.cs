using E_learning.DTO;
using E_learning.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        private StudentService _StudentService;

        public StudentController(ILogger<StudentController> logger, StudentService StudentService)
        {
            _logger = logger;
            _StudentService = StudentService;
        }

        [HttpGet]
        public async Task<ActionResult> GetStudent ()
        {
            try
            {
                var listStudent = _StudentService.GetStudents();
                return Ok(new { result = true, data = listStudent });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET Student !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1Student(StudentDTO newStudent)
        {
            try
            {
                _StudentService.InsertStudent(newStudent);
                return Ok(new { result = true, message = "Insert Student Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert Student Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1Student(StudentDTO newStudent)
        {
            try
            {
                _StudentService.UpdateStudent(newStudent);
                return Ok(new { result = true, message = "Update Student Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update Student Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1Student(string ID_Student)
        {
            try
            {
                _StudentService.RemoveStudent(ID_Student);
                return Ok(new { result = true, message = "Delete Student Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete Student Failed !" });
            }
        }
    }
}
