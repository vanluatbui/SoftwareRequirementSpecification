using E_learning.DTO;
using E_learning.Entity;
using E_learning.Repositories;

namespace E_learning.Services
{
    public class LeaderShipService
    {
        private ILeaderShipRepository _LeaderShipRepository;
        public LeaderShipService(ILeaderShipRepository LeaderShipRepository)
        {
            _LeaderShipRepository = LeaderShipRepository;
        }
        public List<LeaderShipDTO> GetLeaderShips()
        {
            return _LeaderShipRepository.GetLeaderShips();
        }

        public void InsertLeaderShip(LeaderShipDTO newLeader)
        {
            _LeaderShipRepository.InsertLeaderShip(newLeader);
        }

        public void UpdateLeaderShip (LeaderShipDTO newLeader)
        {
            _LeaderShipRepository.UpdateLeaderShip(newLeader);
        }

        public void RemoveLeaderShip(string ID_LeaderShip)
        {
            _LeaderShipRepository.RemoveLeaderShip(ID_LeaderShip);
        }
    }
}
