using E_learning.DTO;
using E_learning.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ILogger<SubjectController> _logger;
        private SubjectService _SubjectService;

        public SubjectController(ILogger<SubjectController> logger, SubjectService SubjectService)
        {
            _logger = logger;
            _SubjectService = SubjectService;
        }

        [HttpGet]
        public async Task<ActionResult> GetSubject ()
        {
            try
            {
                var listSubject = _SubjectService.GetSubjects();
                return Ok(new { result = true, data = listSubject });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET Subject !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1Subject(SubjectDTO newSubject)
        {
            try
            {
                _SubjectService.InsertSubject(newSubject);
                return Ok(new { result = true, message = "Insert Subject Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert Subject Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1Subject(SubjectDTO newSubject)
        {
            try
            {
                _SubjectService.UpdateSubject(newSubject);
                return Ok(new { result = true, message = "Update Subject Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update Subject Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1Subject(string ID_Subject)
        {
            try
            {
                _SubjectService.RemoveSubject(ID_Subject);
                return Ok(new { result = true, message = "Delete Subject Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete Subject Failed !" });
            }
        }
    }
}
