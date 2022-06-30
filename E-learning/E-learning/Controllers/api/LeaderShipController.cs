using E_learning.DTO;
using E_learning.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaderShipController : ControllerBase
    {
        private readonly ILogger<LeaderShipController> _logger;
        private LeaderShipService _LeaderShipService;

        public LeaderShipController(ILogger<LeaderShipController> logger, LeaderShipService LeaderShipService)
        {
            _logger = logger;
            _LeaderShipService = LeaderShipService;
        }

        [HttpGet]
        public async Task<ActionResult> GetLeaderShip ()
        {
            try
            {
                var listLeaderShip = _LeaderShipService.GetLeaderShips();
                return Ok(new { result = true, data = listLeaderShip });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET LeaderShip !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Them1LeaderShip(LeaderShipDTO newLeaderShip)
        {
            try
            {
                _LeaderShipService.InsertLeaderShip(newLeaderShip);
                return Ok(new { result = true, message = "Insert LeaderShip Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Insert LeaderShip Failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> CapNhat1LeaderShip(LeaderShipDTO newLeaderShip)
        {
            try
            {
                _LeaderShipService.UpdateLeaderShip(newLeaderShip);
                return Ok(new { result = true, message = "Update LeaderShip Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Update LeaderShip Failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Xoa1LeaderShip(string ID_LeaderShip)
        {
            try
            {
                _LeaderShipService.RemoveLeaderShip(ID_LeaderShip);
                return Ok(new { result = true, message = "Delete LeaderShip Successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete LeaderShip Failed !" });
            }
        }
    }
}
