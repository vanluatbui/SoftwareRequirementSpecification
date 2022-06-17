using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.Entity;
using E_learning.Model;
using Microsoft.AspNetCore.Identity;

namespace E_learning.Repositories
{
    public interface ILop_MonHocRepository : IRepository<Lop_MonHoc>
    {
        List<Lop_MonHoc> GetLop_MonHocs();
        void InsertLop_MonHoc(Lop_MonHocModel newLop_MonHoc, UserManager<AspNetUser> userManager);
        void UpdateLop_MonHoc(Guid ID, Lop_MonHocModel newLop_MonHoc, UserManager<AspNetUser> userManager);

        void RemoveLop_MonHoc(Guid ID);
    }

    public class Lop_MonHocRespository : RepositoryBase<Lop_MonHoc>, ILop_MonHocRepository
    {
        public Lop_MonHocRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public List<Lop_MonHoc> GetLop_MonHocs()
        {
            var query = _dbcontext.Lop_MonHocs;
            return query.ToList();
        }

        public async void InsertLop_MonHoc(Lop_MonHocModel newLop_MonHoc, UserManager<AspNetUser> userManager)
        {
            var config = new MapperConfiguration(cfg =>
            {
                Lop_MonHocConfig.CreateMap(cfg);
            });

            var mapper = config.CreateMapper();

            Lop_MonHoc lop_mh = new Lop_MonHoc();
            lop_mh = mapper.Map<Lop_MonHocModel, Lop_MonHoc>(newLop_MonHoc);

            lop_mh.ID = Guid.NewGuid();
            lop_mh.Lop = _dbcontext.Lops.First(p => p.ID_Lop ==newLop_MonHoc.ID_Lop);
            lop_mh.MonHoc = _dbcontext.MonHocs.First(p => p.ID_MonHoc == newLop_MonHoc.ID_MonHoc);
            lop_mh.GiaoVien = await userManager.FindByNameAsync(newLop_MonHoc.username_GiaoVien);

            _dbcontext.Lop_MonHocs.Add(lop_mh);
            _dbcontext.SaveChanges();
        }

        public async void UpdateLop_MonHoc(Guid ID, Lop_MonHocModel newLop_MonHoc,UserManager<AspNetUser> userManager)
        {
            Lop_MonHoc lop_mh = _dbcontext.Lop_MonHocs.First(p => p.ID == ID);

            _dbcontext.Entry(lop_mh).CurrentValues.SetValues(newLop_MonHoc);

            lop_mh.ID = Guid.NewGuid();
            lop_mh.Lop = _dbcontext.Lops.First(p => p.ID_Lop == newLop_MonHoc.ID_Lop);
            lop_mh.MonHoc = _dbcontext.MonHocs.First(p => p.ID_MonHoc == newLop_MonHoc.ID_MonHoc);
            lop_mh.GiaoVien = await userManager.FindByNameAsync(newLop_MonHoc.username_GiaoVien);

            _dbcontext.SaveChanges();
        }

        public void RemoveLop_MonHoc(Guid ID)
        {
            Lop_MonHoc lop_mh = _dbcontext.Lop_MonHocs.First(p => p.ID == ID);

            _dbcontext.Lop_MonHocs.Remove(lop_mh);

            _dbcontext.SaveChanges();
        }
    }
}
