using E_learning.DTO;
using E_learning.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class Student_CourseController : ControllerBase
    {
        private readonly ILogger<Student_CourseController> _logger;
        private Student_CourseService _Student_CourseService;

        public Student_CourseController(ILogger<Student_CourseController> logger, Student_CourseService Student_CourseService)
        {
            _logger = logger;
            _Student_CourseService = Student_CourseService;
        }

        [HttpGet]
        public async Task<ActionResult> GetStudent_Course ()
        {
            try
            {
                var listStudent_Course = _Student_CourseService.GetStudent_Courses();
                return Ok(new { result = true, data = listStudent_Course });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET Student_Course !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1Student_Course(Student_CourseDTO newStudent_Course)
        {
            try
            {
                _Student_CourseService.InsertStudent_Course(newStudent_Course);
                return Ok(new { result = true, message = "Insert Student_Course Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert Student_Course Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1Student_Course(Student_CourseDTO newStudent_Course)
        {
            try
            {
                _Student_CourseService.UpdateStudent_Course(newStudent_Course);
                return Ok(new { result = true, message = "Update Student_Course Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update Student_Course Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1Student_Course(string ID_Student, string ID_Course)
        {
            try
            {
                _Student_CourseService.RemoveStudent_Course(ID_Student, ID_Course);
                return Ok(new { result = true, message = "Delete Student_Course Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete Student_Course Failed !" });
            }
        }
    }
}
