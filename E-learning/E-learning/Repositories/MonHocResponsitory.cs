using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.Entity;
using E_learning.Model;

namespace E_learning.Repositories
{
    public interface IMonHocRepository : IRepository<MonHoc>
    {
        List<MonHoc> GetMonHocs();
        void InsertMonHoc(MonHocModel newMH);

        void UpdateMonHoc(Guid ID_MonHoc, MonHocModel newMH);

        void RemoveMonHoc(Guid ID_MonHoc);
    }

    public class MonHocRespository : RepositoryBase<MonHoc>, IMonHocRepository
    {
        public MonHocRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public List<MonHoc> GetMonHocs()
        {
            var query = _dbcontext.MonHocs;
            return query.ToList();
        }

        public void InsertMonHoc(MonHocModel newMH)
        {
            var config = new MapperConfiguration(cfg =>
            {
                MonHocConfig.CreateMap(cfg);
            });

            var mapper = config.CreateMapper();

            MonHoc mh = new MonHoc();
            mh = mapper.Map<MonHocModel, MonHoc>(newMH);
            mh.ID_MonHoc = Guid.NewGuid();

            _dbcontext.MonHocs.Add(mh);
            _dbcontext.SaveChanges();
        }

        public void UpdateMonHoc(Guid ID_MonHoc, MonHocModel newMH)
        {
            MonHoc mh = _dbcontext.MonHocs.First(p => p.ID_MonHoc == ID_MonHoc);

            _dbcontext.Entry(mh).CurrentValues.SetValues(newMH);

            _dbcontext.SaveChanges();
        }

        public void RemoveMonHoc(Guid ID_MonHoc)
        {
            MonHoc mh = _dbcontext.MonHocs.First(p => p.ID_MonHoc == ID_MonHoc);

            _dbcontext.MonHocs.Remove(mh);

            _dbcontext.SaveChanges();
        }
    }
}
