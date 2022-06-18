using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.Entity;
using E_learning.Model;

namespace E_learning.Repositories
{
    public interface IKhoaHocRepository : IRepository<KhoaHoc>
    {
        List<KhoaHoc> GetKhoaHocs();
        void InsertKhoaHoc(KhoaHocModel newKH);

        void UpdateKhoaHoc(Guid ID_KhoaHoc, KhoaHocModel newKH);

        void RemoveKhoaHoc(Guid ID_KhoaHoc);
    }

    public class KhoaHocRespository : RepositoryBase<KhoaHoc>, IKhoaHocRepository
    {
        public KhoaHocRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public List<KhoaHoc> GetKhoaHocs()
        {
            var query = _dbcontext.KhoaHocs;
            return query.ToList();
        }

        public void InsertKhoaHoc(KhoaHocModel newKH)
        {
            var config = new MapperConfiguration(cfg =>
            {
                KhoaHocConfig.CreateMap(cfg);
            });

            var mapper = config.CreateMapper();

            KhoaHoc kh = new KhoaHoc();
            kh = mapper.Map<KhoaHocModel, KhoaHoc>(newKH);

            _dbcontext.KhoaHocs.Add(kh);
            _dbcontext.SaveChanges();
        }

        public void UpdateKhoaHoc(Guid ID_KhoaHoc, KhoaHocModel newKH)
        {
            KhoaHoc kh = _dbcontext.KhoaHocs.First(p => p.ID_KhoaHoc == ID_KhoaHoc);

            _dbcontext.Entry(kh).CurrentValues.SetValues(newKH);

            _dbcontext.SaveChanges();
        }

        public void RemoveKhoaHoc(Guid ID_KhoaHoc)
        {
            KhoaHoc kh = _dbcontext.KhoaHocs.First(p => p.ID_KhoaHoc == ID_KhoaHoc);

            _dbcontext.KhoaHocs.Remove(kh);

            _dbcontext.SaveChanges();
        }
    }
}
