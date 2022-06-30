using E_learning.DTO;
using E_learning.Entity;
using E_learning.Repositories;

namespace E_learning.Services
{
    public class StudentService
    {
        private IStudentRepository _StudentRepository;
        public StudentService(IStudentRepository StudentRepository)
        {
            _StudentRepository = StudentRepository;
        }
        public List<StudentDTO> GetStudents()
        {
            return _StudentRepository.GetStudents();
        }

        public void InsertStudent(StudentDTO newStudent)
        {
            _StudentRepository.InsertStudent(newStudent);
        }

        public void UpdateStudent (StudentDTO newStudent)
        {
            _StudentRepository.UpdateStudent(newStudent);
        }

        public void RemoveStudent(string ID_Student)
        {
            _StudentRepository.RemoveStudent(ID_Student);
        }
    }
}
