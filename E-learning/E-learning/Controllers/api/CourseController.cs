using E_learning.DTO;
using E_learning.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ILogger<CourseController> _logger;
        private CourseService _CourseService;

        public CourseController(ILogger<CourseController> logger, CourseService CourseService)
        {
            _logger = logger;
            _CourseService = CourseService;
        }

        [HttpGet]
        public async Task<ActionResult> GetCourse ()
        {
            try
            {
                var listCourse = _CourseService.GetCourses();
                return Ok(new { result = true, data = listCourse });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET Course !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1Course(CourseDTO newCourse)
        {
            try
            {
                _CourseService.InsertCourse(newCourse);
                return Ok(new { result = true, message = "Insert Course Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert Course Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1Course(CourseDTO newCourse)
        {
            try
            {
                _CourseService.UpdateCourse(newCourse);
                return Ok(new { result = true, message = "Update Course Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update Course Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1Course(string ID_Course)
        {
            try
            {
                _CourseService.RemoveCourse(ID_Course);
                return Ok(new { result = true, message = "Delete Course Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete Course Failed !" });
            }
        }
    }
}
