using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.Entity;
using E_learning.Model;
using Microsoft.AspNetCore.Identity;

namespace E_learning.Repositories
{
    public interface IThoiKhoaBieuRepository : IRepository<ThoiKhoaBieu>
    {
        List<ThoiKhoaBieu> GetThoiKhoaBieus();
        void InsertThoiKhoaBieu(ThoiKhoaBieuModel newThoiKhoaBieu);
        void UpdateThoiKhoaBieu(Guid ID, ThoiKhoaBieuModel newThoiKhoaBieu);

        void RemoveThoiKhoaBieu(Guid ID);
    }

    public class ThoiKhoaBieuRespository : RepositoryBase<ThoiKhoaBieu>, IThoiKhoaBieuRepository
    {
        public ThoiKhoaBieuRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public List<ThoiKhoaBieu> GetThoiKhoaBieus()
        {
            var query = _dbcontext.ThoiKhoaBieus;
            return query.ToList();
        }

        public async void InsertThoiKhoaBieu(ThoiKhoaBieuModel newThoiKhoaBieu)
        {
            var config = new MapperConfiguration(cfg =>
            {
                Model_Config.CreateMap(cfg);
            });

            var mapper = config.CreateMapper();

            ThoiKhoaBieu tkb = new ThoiKhoaBieu();
            tkb = mapper.Map<ThoiKhoaBieuModel, ThoiKhoaBieu>(newThoiKhoaBieu);

            _dbcontext.ThoiKhoaBieus.Add(tkb);
            _dbcontext.SaveChanges();
        }

        public async void UpdateThoiKhoaBieu(Guid ID, ThoiKhoaBieuModel newThoiKhoaBieu)
        {
            ThoiKhoaBieu tkb = _dbcontext.ThoiKhoaBieus.First(p => p.ID == ID);

            _dbcontext.Entry(tkb).CurrentValues.SetValues(newThoiKhoaBieu);

            _dbcontext.SaveChanges();
        }

        public void RemoveThoiKhoaBieu(Guid ID)
        {
            ThoiKhoaBieu tkb = _dbcontext.ThoiKhoaBieus.First(p => p.ID == ID);

            _dbcontext.ThoiKhoaBieus.Remove(tkb);

            _dbcontext.SaveChanges();
        }
    }
}
