using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.DTO;
using E_learning.Entity;

namespace E_learning.Repositories
{
    public interface IResult_StudyRepository : IRepository<Result_Study>
    {
        List<Result_StudyDTO> GetResult_Studys();
        void InsertResult_Study(Result_StudyDTO newResult_Study);

        void UpdateResult_Study(Result_StudyDTO newResult_Study);

        void RemoveResult_Study(string ID_Student, string ID_Subject);
    }

    public class Result_StudyRespository : RepositoryBase<Result_Study>, IResult_StudyRepository
    {
        IMapper mapper;
        public Result_StudyRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
            var config = new MapperConfiguration(cfg =>
            {
                Model_AutoMapper_Config.CreateMap(cfg);
            });

            mapper = config.CreateMapper();
        }

        public List<Result_StudyDTO> GetResult_Studys()
        {
            List<Result_Study> listResult_Study = _dbcontext.Result_Studys.ToList();

            //Auto Mapper

            List<Result_StudyDTO> listResult_StudyDTO = listResult_Study.Select(emp => mapper.Map<Result_Study, Result_StudyDTO>(emp)).ToList();

            return listResult_StudyDTO;

        }

        public void InsertResult_Study(Result_StudyDTO newResult_Study)
        {
            // Auto Mapper

            Result_Study Result_Study = mapper.Map<Result_StudyDTO, Result_Study>(newResult_Study);

            _dbcontext.Result_Studys.Add(Result_Study);
            _dbcontext.SaveChanges();
        }

        public void UpdateResult_Study(Result_StudyDTO newResult_Study)
        {
            Result_Study Result_Study = _dbcontext.Result_Studys.First(p => p.ID_Student == newResult_Study.ID_Student
            && p.ID_Subject == newResult_Study.ID_Subject);

            _dbcontext.Entry(Result_Study).CurrentValues.SetValues(newResult_Study);

            _dbcontext.SaveChanges();
        }

        public void RemoveResult_Study(string ID_Student, string ID_Subject)
        {
            Result_Study Result_Study = _dbcontext.Result_Studys.First(p => p.ID_Student == ID_Student && p.ID_Subject == ID_Subject);

            _dbcontext.Result_Studys.Remove(Result_Study);

            _dbcontext.SaveChanges();
        }
    }
}
