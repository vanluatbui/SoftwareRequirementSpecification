using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.DTO;
using E_learning.Entity;

namespace E_learning.Repositories
{
    public interface ITeacherRepository : IRepository<Teacher>
    {
        List<TeacherDTO> GetTeachers();
        void InsertTeacher(TeacherDTO newTeacher);

        void UpdateTeacher(TeacherDTO newTeacher);

        void RemoveTeacher(string ID_Teacher);
    }

    public class TeacherRespository : RepositoryBase<Teacher>, ITeacherRepository
    {
        IMapper mapper;
        public TeacherRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
            var config = new MapperConfiguration(cfg =>
            {
                Model_AutoMapper_Config.CreateMap(cfg);
            });

            mapper = config.CreateMapper();
        }

        public List<TeacherDTO> GetTeachers()
        {
            List<Teacher> listTeacher = _dbcontext.Teachers.ToList();

            //Auto Mapper

            List<TeacherDTO> listTeacherDTO = listTeacher.Select(emp => mapper.Map<Teacher, TeacherDTO>(emp)).ToList();

            return listTeacherDTO;

        }

        public void InsertTeacher(TeacherDTO newTeacher)
        {
            // Auto Mapper

            Teacher Teacher = mapper.Map<TeacherDTO, Teacher>(newTeacher);

            _dbcontext.Teachers.Add(Teacher);
            _dbcontext.SaveChanges();
        }

        public void UpdateTeacher(TeacherDTO newTeacher)
        {
            Teacher Teacher = _dbcontext.Teachers.First(p => p.ID_Teacher == newTeacher.ID_Teacher);

            _dbcontext.Entry(Teacher).CurrentValues.SetValues(newTeacher);

            _dbcontext.SaveChanges();
        }

        public void RemoveTeacher(string ID_Teacher)
        {
            Teacher Teacher = _dbcontext.Teachers.First(p => p.ID_Teacher == ID_Teacher);

            _dbcontext.Teachers.Remove(Teacher);

            _dbcontext.SaveChanges();
        }
    }
}
