using E_learning.DTO;
using E_learning.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ILogger<TeacherController> _logger;
        private TeacherService _TeacherService;

        public TeacherController(ILogger<TeacherController> logger, TeacherService TeacherService)
        {
            _logger = logger;
            _TeacherService = TeacherService;
        }

        [HttpGet]
        public async Task<ActionResult> GetTeacher ()
        {
            try
            {
                var listTeacher = _TeacherService.GetTeachers();
                return Ok(new { result = true, data = listTeacher });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET Teacher !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1Teacher(TeacherDTO newTeacher)
        {
            try
            {
                _TeacherService.InsertTeacher(newTeacher);
                return Ok(new { result = true, message = "Insert Teacher Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert Teacher Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1Teacher(TeacherDTO newTeacher)
        {
            try
            {
                _TeacherService.UpdateTeacher(newTeacher);
                return Ok(new { result = true, message = "Update Teacher Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update Teacher Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1Teacher(string ID_Teacher)
        {
            try
            {
                _TeacherService.RemoveTeacher(ID_Teacher);
                return Ok(new { result = true, message = "Delete Teacher Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete Teacher Failed !" });
            }
        }
    }
}
