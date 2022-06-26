using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.Entity;
using E_learning.Model;

namespace E_learning.Repositories
{
    public interface IHinhThuc_Thi_KiemTraRepository : IRepository<HinhThuc_Thi_KiemTra>
    {
        List<HinhThuc_Thi_KiemTra> GetHinhThuc_Thi_KiemTras();
        void InsertHinhThuc_Thi_KiemTra(HinhThuc_Thi_KiemTraModel newHT);

        void UpdateHinhThuc_Thi_KiemTra(Guid ID_HinhThuc_Thi_KiemTra, HinhThuc_Thi_KiemTraModel newHT);

        void RemoveHinhThuc_Thi_KiemTra(Guid ID_HinhThuc_Thi_KiemTra);
    }

    public class HinhThuc_Thi_KiemTraRespository : RepositoryBase<HinhThuc_Thi_KiemTra>, IHinhThuc_Thi_KiemTraRepository
    {
        public HinhThuc_Thi_KiemTraRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public List<HinhThuc_Thi_KiemTra> GetHinhThuc_Thi_KiemTras()
        {
            var query = _dbcontext.HinhThuc_Thi_KiemTras;
            return query.ToList();
        }

        public void InsertHinhThuc_Thi_KiemTra(HinhThuc_Thi_KiemTraModel newHT)
        {
            var config = new MapperConfiguration(cfg =>
            {
                Model_Config.CreateMap(cfg);
            });

            var mapper = config.CreateMapper();

            HinhThuc_Thi_KiemTra ht = new HinhThuc_Thi_KiemTra();
            ht = mapper.Map<HinhThuc_Thi_KiemTraModel, HinhThuc_Thi_KiemTra>(newHT);

            _dbcontext.HinhThuc_Thi_KiemTras.Add(ht);
            _dbcontext.SaveChanges();
        }

        public void UpdateHinhThuc_Thi_KiemTra(Guid ID_HinhThuc_Thi_KiemTra, HinhThuc_Thi_KiemTraModel newHT)
        {
            HinhThuc_Thi_KiemTra ht = _dbcontext.HinhThuc_Thi_KiemTras.First(p => p.ID_HinhThuc == ID_HinhThuc_Thi_KiemTra);

            _dbcontext.Entry(ht).CurrentValues.SetValues(newHT);

            _dbcontext.SaveChanges();
        }

        public void RemoveHinhThuc_Thi_KiemTra(Guid ID_HinhThuc_Thi_KiemTra)
        {
            HinhThuc_Thi_KiemTra ht = _dbcontext.HinhThuc_Thi_KiemTras.First(p => p.ID_HinhThuc == ID_HinhThuc_Thi_KiemTra);

            _dbcontext.HinhThuc_Thi_KiemTras.Remove(ht);

            _dbcontext.SaveChanges();
        }
    }
}
