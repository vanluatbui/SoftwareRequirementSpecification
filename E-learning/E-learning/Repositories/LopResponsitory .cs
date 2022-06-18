using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.Entity;
using E_learning.Model;
using Microsoft.AspNetCore.Identity;

namespace E_learning.Repositories
{
    public interface ILopRepository : IRepository<Lop>
    {
        List<Lop> GetLops();
        void InsertLop(LopModel newLop);

        void UpdateLop(Guid ID_Lop, LopModel newLop);

        void RemoveLop(Guid ID_Lop);
    }

    public class LopRespository : RepositoryBase<Lop>, ILopRepository
    {
        public LopRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public List<Lop> GetLops()
        {
            var query = _dbcontext.Lops;
            
            return query.ToList();
        }

        public async void InsertLop(LopModel newLop)
        {
            var config = new MapperConfiguration(cfg =>
            {
                LopConfig.CreateMap(cfg);
            });

            var mapper = config.CreateMapper();

            Lop lop = new Lop();
            lop = mapper.Map<LopModel, Lop>(newLop);

            _dbcontext.Lops.Add(lop);
            _dbcontext.SaveChanges();
        }

        public async void UpdateLop (Guid ID_Lop, LopModel newLop)
        {
            Lop lop = _dbcontext.Lops.First(p => p.ID_Lop == ID_Lop);

            _dbcontext.Entry(lop).CurrentValues.SetValues(newLop);

            _dbcontext.SaveChanges();
        }

        public void RemoveLop(Guid ID_Lop)
        {
            Lop lop = _dbcontext.Lops.First(p => p.ID_Lop == ID_Lop);

            _dbcontext.Lops.Remove(lop);

            _dbcontext.SaveChanges();
        }
    }
}
