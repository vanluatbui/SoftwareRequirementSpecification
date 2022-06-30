using E_learning.DTO;
using E_learning.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class Student_File_ExamController : ControllerBase
    {
        private readonly ILogger<Student_File_ExamController> _logger;
        private Student_File_ExamService _Student_File_ExamService;

        public Student_File_ExamController(ILogger<Student_File_ExamController> logger, Student_File_ExamService Student_File_ExamService)
        {
            _logger = logger;
            _Student_File_ExamService = Student_File_ExamService;
        }

        [HttpGet]
        public async Task<ActionResult> GetStudent_File_Exam ()
        {
            try
            {
                var listStudent_File_Exam = _Student_File_ExamService.GetStudent_File_Exams();
                return Ok(new { result = true, data = listStudent_File_Exam });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET Student_File_Exam !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1Student_File_Exam(Student_File_ExamDTO newStudent_File_Exam)
        {
            try
            {
                _Student_File_ExamService.InsertStudent_File_Exam(newStudent_File_Exam);
                return Ok(new { result = true, message = "Insert Student_File_Exam Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert Student_File_Exam Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1Student_File_Exam(Student_File_ExamDTO newStudent_File_Exam)
        {
            try
            {
                _Student_File_ExamService.UpdateStudent_File_Exam(newStudent_File_Exam);
                return Ok(new { result = true, message = "Update Student_File_Exam Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update Student_File_Exam Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1Student_File_Exam(string ID_Student_File_Exam)
        {
            try
            {
                _Student_File_ExamService.RemoveStudent_File_Exam(ID_Student_File_Exam);
                return Ok(new { result = true, message = "Delete Student_File_Exam Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete Student_File_Exam Failed !" });
            }
        }
    }
}
