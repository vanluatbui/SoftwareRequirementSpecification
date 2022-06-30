using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.DTO;
using E_learning.Entity;

namespace E_learning.Repositories
{
    public interface ILeaderShipRepository : IRepository<LeaderShip>
    {
        List<LeaderShipDTO> GetLeaderShips();
        void InsertLeaderShip(LeaderShipDTO newLeader);

        void UpdateLeaderShip(LeaderShipDTO newLeader);

        void RemoveLeaderShip(string ID_LeaderShip);
    }

    public class LeaderShipRespository : RepositoryBase<LeaderShip>, ILeaderShipRepository
    {
        IMapper mapper;
        public LeaderShipRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
            var config = new MapperConfiguration(cfg =>
            {
                Model_AutoMapper_Config.CreateMap(cfg);
            });

            mapper = config.CreateMapper();
        }

        public List<LeaderShipDTO> GetLeaderShips()
        {
            List<LeaderShip> listLeaderShip = _dbcontext.LeaderShips.ToList();

            //Auto Mapper

            List<LeaderShipDTO> listLeaderShipDTO = listLeaderShip.Select(emp => mapper.Map<LeaderShip, LeaderShipDTO>(emp)).ToList();

            return listLeaderShipDTO;

        }

        public void InsertLeaderShip(LeaderShipDTO newLeader)
        {
            // Auto Mapper

            LeaderShip leader = mapper.Map<LeaderShipDTO, LeaderShip>(newLeader);

            _dbcontext.LeaderShips.Add(leader);
            _dbcontext.SaveChanges();
        }

        public void UpdateLeaderShip(LeaderShipDTO newLeader)
        {
            LeaderShip leader = _dbcontext.LeaderShips.First(p => p.ID_LeaderShip == newLeader.ID_LeaderShip);

            _dbcontext.Entry(leader).CurrentValues.SetValues(newLeader);

            _dbcontext.SaveChanges();
        }

        public void RemoveLeaderShip(string ID_LeaderShip)
        {
            LeaderShip leader = _dbcontext.LeaderShips.First(p => p.ID_LeaderShip == ID_LeaderShip);

            _dbcontext.LeaderShips.Remove(leader);

            _dbcontext.SaveChanges();
        }
    }
}
