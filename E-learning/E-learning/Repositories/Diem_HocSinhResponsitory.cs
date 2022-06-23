using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.Entity;
using E_learning.Model;

namespace E_learning.Repositories
{
    public interface IDiem_HocSinhRepository : IRepository<Diem_HocSinh>
    {
        List<Diem_HocSinh> GetDiem_HocSinhs();
        void InsertDiem_HocSinh(Diem_HocSinhModel newKQ);

        void UpdateDiem_HocSinh(Guid ID_Diem_HocSinh, Diem_HocSinhModel newKQ);

        void RemoveDiem_HocSinh(Guid ID_Diem_HocSinh);
    }

    public class Diem_HocSinhRespository : RepositoryBase<Diem_HocSinh>, IDiem_HocSinhRepository
    {
        public Diem_HocSinhRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public List<Diem_HocSinh> GetDiem_HocSinhs()
        {
            var query = _dbcontext.Diem_HocSinhs;
            return query.ToList();
        }

        public void InsertDiem_HocSinh(Diem_HocSinhModel newKQ)
        {
            var config = new MapperConfiguration(cfg =>
            {
                Diem_HocSinhConfig.CreateMap(cfg);
            });

            var mapper = config.CreateMapper();

            Diem_HocSinh kq = new Diem_HocSinh();
            kq = mapper.Map<Diem_HocSinhModel, Diem_HocSinh>(newKQ);

            _dbcontext.Diem_HocSinhs.Add(kq);
            _dbcontext.SaveChanges();
        }

        public void UpdateDiem_HocSinh(Guid ID_Diem_HocSinh, Diem_HocSinhModel newKQ)
        {
            Diem_HocSinh kq = _dbcontext.Diem_HocSinhs.First(p => p.ID== ID_Diem_HocSinh);

            _dbcontext.Entry(kq).CurrentValues.SetValues(newKQ);

            _dbcontext.SaveChanges();
        }

        public void RemoveDiem_HocSinh(Guid ID_Diem_HocSinh)
        {
            Diem_HocSinh kq = _dbcontext.Diem_HocSinhs.First(p => p.ID == ID_Diem_HocSinh);

            _dbcontext.Diem_HocSinhs.Remove(kq);

            _dbcontext.SaveChanges();
        }
    }
}
