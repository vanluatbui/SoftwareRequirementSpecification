using E_learning.DTO;
using E_learning.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class File_ExamController : ControllerBase
    {
        private readonly ILogger<File_ExamController> _logger;
        private File_ExamService _File_ExamService;

        public File_ExamController(ILogger<File_ExamController> logger, File_ExamService File_ExamService)
        {
            _logger = logger;
            _File_ExamService = File_ExamService;
        }

        [HttpGet]
        public async Task<ActionResult> GetFile_Exam ()
        {
            try
            {
                var listFile_Exam = _File_ExamService.GetFile_Exams();
                return Ok(new { result = true, data = listFile_Exam });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET File_Exam !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1File_Exam(File_ExamDTO newFile_Exam)
        {
            try
            {
                _File_ExamService.InsertFile_Exam(newFile_Exam);
                return Ok(new { result = true, message = "Insert File_Exam Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert File_Exam Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1File_Exam(File_ExamDTO newFile_Exam)
        {
            try
            {
                _File_ExamService.UpdateFile_Exam(newFile_Exam);
                return Ok(new { result = true, message = "Update File_Exam Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update File_Exam Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1File_Exam(string ID_File_Exam)
        {
            try
            {
                _File_ExamService.RemoveFile_Exam(ID_File_Exam);
                return Ok(new { result = true, message = "Delete File_Exam Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete File_Exam Failed !" });
            }
        }
    }
}
