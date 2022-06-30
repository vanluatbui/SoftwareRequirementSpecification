using E_learning.DTO;
using E_learning.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemesterController : ControllerBase
    {
        private readonly ILogger<SemesterController> _logger;
        private SemesterService _SemesterService;

        public SemesterController(ILogger<SemesterController> logger, SemesterService SemesterService)
        {
            _logger = logger;
            _SemesterService = SemesterService;
        }

        [HttpGet]
        public async Task<ActionResult> GetSemester ()
        {
            try
            {
                var listSemester = _SemesterService.GetSemesters();
                return Ok(new { result = true, data = listSemester });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET Semester !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1Semester(SemesterDTO newSemester)
        {
            try
            {
                _SemesterService.InsertSemester(newSemester);
                return Ok(new { result = true, message = "Insert Semester Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert Semester Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1Semester(SemesterDTO newSemester)
        {
            try
            {
                _SemesterService.UpdateSemester(newSemester);
                return Ok(new { result = true, message = "Update Semester Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update Semester Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1Semester(string ID_Semester)
        {
            try
            {
                _SemesterService.RemoveSemester(ID_Semester);
                return Ok(new { result = true, message = "Delete Semester Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete Semester Failed !" });
            }
        }
    }
}
