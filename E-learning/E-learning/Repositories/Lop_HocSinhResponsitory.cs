using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.Entity;
using E_learning.Model;
using Microsoft.AspNetCore.Identity;

namespace E_learning.Repositories
{
    public interface ILop_HocSinhRepository : IRepository<Lop_HocSinh>
    {
        List<Lop_HocSinh> GetLop_HocSinhs();
        void InsertLop_HocSinh(Lop_HocSinhModel newLop_HocSinh, UserManager<AspNetUser> userManager);
        void UpdateLop_HocSinh(Guid ID, LopModel newLop_HocSinh);

        void RemoveLop_HocSinh(Guid ID);
    }

    public class Lop_HocSinhRespository : RepositoryBase<Lop_HocSinh>, ILop_HocSinhRepository
    {
        public Lop_HocSinhRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public List<Lop_HocSinh> GetLop_HocSinhs()
        {
            var query = _dbcontext.Lop_HocSinhs;
            return query.ToList();
        }

        public async void InsertLop_HocSinh(Lop_HocSinhModel newLop_HocSinh, UserManager<AspNetUser> userManager)
        {
            var config = new MapperConfiguration(cfg =>
            {
                Lop_HocSinhConfig.CreateMap(cfg);
            });

            var mapper = config.CreateMapper();

            Lop_HocSinh Lop_HocSinh = new Lop_HocSinh();
            Lop_HocSinh = mapper.Map<Lop_HocSinhModel, Lop_HocSinh>(newLop_HocSinh);

            Lop_HocSinh.ID = Guid.NewGuid();
            Lop_HocSinh.Lop = _dbcontext.Lops.First(p => p.ID_Lop ==newLop_HocSinh.ID_Lop);
            Lop_HocSinh.HocSinh = await userManager.FindByNameAsync(newLop_HocSinh.username_HocSinh);

            _dbcontext.Lop_HocSinhs.Add(Lop_HocSinh);
            _dbcontext.SaveChanges();
        }

        public void UpdateLop_HocSinh(Guid ID, LopModel newLop_HocSinh)
        {
            Lop_HocSinh lop_hs = _dbcontext.Lop_HocSinhs.First(p => p.ID == ID);

            _dbcontext.Entry(lop_hs).CurrentValues.SetValues(newLop_HocSinh);

            _dbcontext.SaveChanges();
        }

        public void RemoveLop_HocSinh(Guid ID)
        {
            Lop_HocSinh lop_hs = _dbcontext.Lop_HocSinhs.First(p => p.ID == ID);

            _dbcontext.Lop_HocSinhs.Remove(lop_hs);

            _dbcontext.SaveChanges();
        }
    }
}
