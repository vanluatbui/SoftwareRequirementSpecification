using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.Entity;
using E_learning.Model;

namespace E_learning.Repositories
{
    public interface ILop_Thi_KiemTraRepository : IRepository<Lop_Thi_KiemTra>
    {
        List<Lop_Thi_KiemTra> GetLop_Thi_KiemTras();
        void InsertLop_Thi_KiemTra(Lop_Thi_KiemTraModel newKT);

        void UpdateLop_Thi_KiemTra(Guid ID_Lop_Thi_KiemTra, Lop_Thi_KiemTraModel newKT);

        void RemoveLop_Thi_KiemTra(Guid ID_Lop_Thi_KiemTra);
    }

    public class Lop_Thi_KiemTraRespository : RepositoryBase<Lop_Thi_KiemTra>, ILop_Thi_KiemTraRepository
    {
        public Lop_Thi_KiemTraRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public List<Lop_Thi_KiemTra> GetLop_Thi_KiemTras()
        {
            var query = _dbcontext.Lop_Thi_KiemTras;
            return query.ToList();
        }

        public void InsertLop_Thi_KiemTra(Lop_Thi_KiemTraModel newKT)
        {
            var config = new MapperConfiguration(cfg =>
            {
                Model_Config.CreateMap(cfg);
            });

            var mapper = config.CreateMapper();

            Lop_Thi_KiemTra kt = new Lop_Thi_KiemTra();
            kt = mapper.Map<Lop_Thi_KiemTraModel, Lop_Thi_KiemTra>(newKT);

            _dbcontext.Lop_Thi_KiemTras.Add(kt);
            _dbcontext.SaveChanges();
        }

        public void UpdateLop_Thi_KiemTra(Guid ID_Lop_Thi_KiemTra, Lop_Thi_KiemTraModel newKT)
        {
            Lop_Thi_KiemTra kt = _dbcontext.Lop_Thi_KiemTras.First(p => p.ID == ID_Lop_Thi_KiemTra);

            _dbcontext.Entry(kt).CurrentValues.SetValues(newKT);

            _dbcontext.SaveChanges();
        }

        public void RemoveLop_Thi_KiemTra(Guid ID_Lop_Thi_KiemTra)
        {
            Lop_Thi_KiemTra kt = _dbcontext.Lop_Thi_KiemTras.First(p => p.ID == ID_Lop_Thi_KiemTra);

            _dbcontext.Lop_Thi_KiemTras.Remove(kt);

            _dbcontext.SaveChanges();
        }
    }
}
