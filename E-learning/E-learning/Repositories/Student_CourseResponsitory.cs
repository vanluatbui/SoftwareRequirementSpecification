using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.DTO;
using E_learning.Entity;

namespace E_learning.Repositories
{
    public interface IStudent_CourseRepository : IRepository<Student_Course>
    {
        List<Student_CourseDTO> GetStudent_Courses();
        void InsertStudent_Course(Student_CourseDTO newStudent_Course);

        void UpdateStudent_Course(Student_CourseDTO newStudent_Course);

        void RemoveStudent_Course(string ID_Student, string ID_Course);
    }

    public class Student_CourseRespository : RepositoryBase<Student_Course>, IStudent_CourseRepository
    {
        IMapper mapper;
        public Student_CourseRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
            var config = new MapperConfiguration(cfg =>
            {
                Model_AutoMapper_Config.CreateMap(cfg);
            });

            mapper = config.CreateMapper();
        }

        public List<Student_CourseDTO> GetStudent_Courses()
        {
            List<Student_Course> listStudent_Course = _dbcontext.Student_Courses.ToList();

            //Auto Mapper

            List<Student_CourseDTO> listStudent_CourseDTO = listStudent_Course.Select(emp => mapper.Map<Student_Course, Student_CourseDTO>(emp)).ToList();

            return listStudent_CourseDTO;

        }

        public void InsertStudent_Course(Student_CourseDTO newStudent_Course)
        {
            // Auto Mapper

            Student_Course Student_Course = mapper.Map<Student_CourseDTO, Student_Course>(newStudent_Course);

            _dbcontext.Student_Courses.Add(Student_Course);
            _dbcontext.SaveChanges();
        }

        public void UpdateStudent_Course(Student_CourseDTO newStudent_Course)
        {
            Student_Course Student_Course = _dbcontext.Student_Courses.First(p => p.ID_Student == newStudent_Course.ID_Student 
            && p.ID_Course == newStudent_Course.ID_Course);

            _dbcontext.Entry(Student_Course).CurrentValues.SetValues(newStudent_Course);

            _dbcontext.SaveChanges();
        }

        public void RemoveStudent_Course(string ID_Student, string ID_Course)
        {
            Student_Course Student_Course = _dbcontext.Student_Courses.First(p => p.ID_Student == ID_Student && p.ID_Course == ID_Course);

            _dbcontext.Student_Courses.Remove(Student_Course);

            _dbcontext.SaveChanges();
        }
    }
}
