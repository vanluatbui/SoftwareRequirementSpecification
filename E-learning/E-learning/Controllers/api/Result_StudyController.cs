using E_learning.DTO;
using E_learning.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class Result_StudyController : ControllerBase
    {
        private readonly ILogger<Result_StudyController> _logger;
        private Result_StudyService _Result_StudyService;

        public Result_StudyController(ILogger<Result_StudyController> logger, Result_StudyService Result_StudyService)
        {
            _logger = logger;
            _Result_StudyService = Result_StudyService;
        }

        [HttpGet]
        public async Task<ActionResult> GetResult_Study ()
        {
            try
            {
                var listResult_Study = _Result_StudyService.GetResult_Studys();
                return Ok(new { result = true, data = listResult_Study });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET Result_Study !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1Result_Study(Result_StudyDTO newResult_Study)
        {
            try
            {
                _Result_StudyService.InsertResult_Study(newResult_Study);
                return Ok(new { result = true, message = "Insert Result_Study Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert Result_Study Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1Result_Study(Result_StudyDTO newResult_Study)
        {
            try
            {
                _Result_StudyService.UpdateResult_Study(newResult_Study);
                return Ok(new { result = true, message = "Update Result_Study Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update Result_Study Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1Result_Study(string ID_Student, string ID_Subject)
        {
            try
            {
                _Result_StudyService.RemoveResult_Study(ID_Student, ID_Subject);
                return Ok(new { result = true, message = "Delete Result_Study Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete Result_Study Failed !" });
            }
        }
    }
}
