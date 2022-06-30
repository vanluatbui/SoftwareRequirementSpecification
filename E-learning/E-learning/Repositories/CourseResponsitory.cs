using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.DTO;
using E_learning.Entity;

namespace E_learning.Repositories
{
    public interface ICourseRepository : IRepository<Course>
    {
        List<CourseDTO> GetCourses();
        void InsertCourse(CourseDTO newCourse);

        void UpdateCourse(CourseDTO newCourse);

        void RemoveCourse(string ID_Course);
    }

    public class CourseRespository : RepositoryBase<Course>, ICourseRepository
    {
        IMapper mapper;
        public CourseRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
            var config = new MapperConfiguration(cfg =>
            {
                Model_AutoMapper_Config.CreateMap(cfg);
            });

            mapper = config.CreateMapper();
        }

        public List<CourseDTO> GetCourses()
        {
            List<Course> listCourse = _dbcontext.Courses.ToList();

            //Auto Mapper

            List<CourseDTO> listCourseDTO = listCourse.Select(emp => mapper.Map<Course, CourseDTO>(emp)).ToList();

            return listCourseDTO;

        }

        public void InsertCourse(CourseDTO newCourse)
        {
            // Auto Mapper

            Course Course = mapper.Map<CourseDTO, Course>(newCourse);

            _dbcontext.Courses.Add(Course);
            _dbcontext.SaveChanges();
        }

        public void UpdateCourse(CourseDTO newCourse)
        {
            Course Course = _dbcontext.Courses.First(p => p.ID_Course == newCourse.ID_Course);

            _dbcontext.Entry(Course).CurrentValues.SetValues(newCourse);

            _dbcontext.SaveChanges();
        }

        public void RemoveCourse(string ID_Course)
        {
            Course Course = _dbcontext.Courses.First(p => p.ID_Course == ID_Course);

            _dbcontext.Courses.Remove(Course);

            _dbcontext.SaveChanges();
        }
    }
}
