using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.DTO;
using E_learning.Entity;

namespace E_learning.Repositories
{
    public interface ISemesterRepository : IRepository<Semester>
    {
        List<SemesterDTO> GetSemesters();
        void InsertSemester(SemesterDTO newSemester);

        void UpdateSemester(SemesterDTO newSemester);

        void RemoveSemester(string ID_Semester);
    }

    public class SemesterRespository : RepositoryBase<Semester>, ISemesterRepository
    {
        IMapper mapper;
        public SemesterRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
            var config = new MapperConfiguration(cfg =>
            {
                Model_AutoMapper_Config.CreateMap(cfg);
            });

            mapper = config.CreateMapper();
        }

        public List<SemesterDTO> GetSemesters()
        {
            List<Semester> listSemester = _dbcontext.Semesters.ToList();

            //Auto Mapper

            List<SemesterDTO> listSemesterDTO = listSemester.Select(emp => mapper.Map<Semester, SemesterDTO>(emp)).ToList();

            return listSemesterDTO;

        }

        public void InsertSemester(SemesterDTO newSemester)
        {
            // Auto Mapper

            Semester Semester = mapper.Map<SemesterDTO, Semester>(newSemester);

            _dbcontext.Semesters.Add(Semester);
            _dbcontext.SaveChanges();
        }

        public void UpdateSemester(SemesterDTO newSemester)
        {
            Semester Semester = _dbcontext.Semesters.First(p => p.ID_Semester == newSemester.ID_Semester);

            _dbcontext.Entry(Semester).CurrentValues.SetValues(newSemester);

            _dbcontext.SaveChanges();
        }

        public void RemoveSemester(string ID_Semester)
        {
            Semester Semester = _dbcontext.Semesters.First(p => p.ID_Semester == ID_Semester);

            _dbcontext.Semesters.Remove(Semester);

            _dbcontext.SaveChanges();
        }
    }
}
