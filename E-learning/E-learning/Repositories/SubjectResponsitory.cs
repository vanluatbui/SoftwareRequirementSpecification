using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.DTO;
using E_learning.Entity;

namespace E_learning.Repositories
{
    public interface ISubjectRepository : IRepository<Subject>
    {
        List<SubjectDTO> GetSubjects();
        void InsertSubject(SubjectDTO newSubject);

        void UpdateSubject(SubjectDTO newSubject);

        void RemoveSubject(string ID_Subject);
    }

    public class SubjectRespository : RepositoryBase<Subject>, ISubjectRepository
    {
        IMapper mapper;
        public SubjectRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
            var config = new MapperConfiguration(cfg =>
            {
                Model_AutoMapper_Config.CreateMap(cfg);
            });

            mapper = config.CreateMapper();
        }

        public List<SubjectDTO> GetSubjects()
        {
            List<Subject> listSubject = _dbcontext.Subjects.ToList();

            //Auto Mapper

            List<SubjectDTO> listSubjectDTO = listSubject.Select(emp => mapper.Map<Subject, SubjectDTO>(emp)).ToList();

            return listSubjectDTO;

        }

        public void InsertSubject(SubjectDTO newSubject)
        {
            // Auto Mapper

            Subject Subject = mapper.Map<SubjectDTO, Subject>(newSubject);

            _dbcontext.Subjects.Add(Subject);
            _dbcontext.SaveChanges();
        }

        public void UpdateSubject(SubjectDTO newSubject)
        {
            Subject Subject = _dbcontext.Subjects.First(p => p.ID_Subject == newSubject.ID_Subject);

            _dbcontext.Entry(Subject).CurrentValues.SetValues(newSubject);

            _dbcontext.SaveChanges();
        }

        public void RemoveSubject(string ID_Subject)
        {
            Subject Subject = _dbcontext.Subjects.First(p => p.ID_Subject == ID_Subject);

            _dbcontext.Subjects.Remove(Subject);

            _dbcontext.SaveChanges();
        }
    }
}
