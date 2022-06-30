using E_learning.DTO;
using E_learning.Entity;
using E_learning.Repositories;

namespace E_learning.Services
{
    public class Student_TestService
    {
        private IStudent_TestRepository _Student_TestRepository;
        public Student_TestService(IStudent_TestRepository Student_TestRepository)
        {
            _Student_TestRepository = Student_TestRepository;
        }
        public List<Student_TestDTO> GetStudent_Tests()
        {
            return _Student_TestRepository.GetStudent_Tests();
        }

        public void InsertStudent_Test(Student_TestDTO newStudent_Test)
        {
            _Student_TestRepository.InsertStudent_Test(newStudent_Test);
        }

        public void UpdateStudent_Test (Student_TestDTO newStudent_Test)
        {
            _Student_TestRepository.UpdateStudent_Test(newStudent_Test);
        }

        public void RemoveStudent_Test(string ID_Student, string ID_Class_Test)
        {
            _Student_TestRepository.RemoveStudent_Test(ID_Student, ID_Class_Test);
        }
    }
}
