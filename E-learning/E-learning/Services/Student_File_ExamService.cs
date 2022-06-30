using E_learning.DTO;
using E_learning.Entity;
using E_learning.DTO;
using E_learning.Repositories;

namespace E_learning.Services
{
    public class Student_File_ExamService
    {
        private IStudent_File_ExamRepository _Student_File_ExamRepository;
        public Student_File_ExamService(IStudent_File_ExamRepository Student_File_ExamRepository)
        {
            _Student_File_ExamRepository = Student_File_ExamRepository;
        }
        public List<Student_File_ExamDTO> GetStudent_File_Exams()
        {
            return _Student_File_ExamRepository.GetStudent_File_Exams();
        }

        public void InsertStudent_File_Exam(Student_File_ExamDTO newStudent_File_Exam)
        {
            _Student_File_ExamRepository.InsertStudent_File_Exam(newStudent_File_Exam);
        }

        public void UpdateStudent_File_Exam (Student_File_ExamDTO newStudent_File_Exam)
        {
            _Student_File_ExamRepository.UpdateStudent_File_Exam(newStudent_File_Exam);
        }

        public void RemoveStudent_File_Exam(string ID_Student_File_Exam)
        {
            _Student_File_ExamRepository.RemoveStudent_File_Exam(ID_Student_File_Exam);
        }
    }
}
