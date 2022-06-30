using E_learning.DTO;
using E_learning.Entity;
using E_learning.Repositories;

namespace E_learning.Services
{
    public class Student_CourseService
    {
        private IStudent_CourseRepository _Student_CourseRepository;
        public Student_CourseService(IStudent_CourseRepository Student_CourseRepository)
        {
            _Student_CourseRepository = Student_CourseRepository;
        }
        public List<Student_CourseDTO> GetStudent_Courses()
        {
            return _Student_CourseRepository.GetStudent_Courses();
        }

        public void InsertStudent_Course(Student_CourseDTO newStudent_Course)
        {
            _Student_CourseRepository.InsertStudent_Course(newStudent_Course);
        }

        public void UpdateStudent_Course (Student_CourseDTO newStudent_Course)
        {
            _Student_CourseRepository.UpdateStudent_Course(newStudent_Course);
        }

        public void RemoveStudent_Course(string ID_Student, string ID_Course)
        {
            _Student_CourseRepository.RemoveStudent_Course(ID_Student, ID_Course);
        }
    }
}
