using E_learning.DTO;
using E_learning.Entity;
using E_learning.Repositories;

namespace E_learning.Services
{
    public class CourseService
    {
        private ICourseRepository _CourseRepository;
        public CourseService(ICourseRepository CourseRepository)
        {
            _CourseRepository = CourseRepository;
        }
        public List<CourseDTO> GetCourses()
        {
            return _CourseRepository.GetCourses();
        }

        public void InsertCourse(CourseDTO newCourse)
        {
            _CourseRepository.InsertCourse(newCourse);
        }

        public void UpdateCourse (CourseDTO newCourse)
        {
            _CourseRepository.UpdateCourse(newCourse);
        }

        public void RemoveCourse(string ID_Course)
        {
            _CourseRepository.RemoveCourse(ID_Course);
        }
    }
}
