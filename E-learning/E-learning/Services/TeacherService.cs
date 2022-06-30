using E_learning.DTO;
using E_learning.Entity;
using E_learning.Repositories;

namespace E_learning.Services
{
    public class TeacherService
    {
        private ITeacherRepository _TeacherRepository;
        public TeacherService(ITeacherRepository TeacherRepository)
        {
            _TeacherRepository = TeacherRepository;
        }
        public List<TeacherDTO> GetTeachers()
        {
            return _TeacherRepository.GetTeachers();
        }

        public void InsertTeacher(TeacherDTO newTeacher)
        {
            _TeacherRepository.InsertTeacher(newTeacher);
        }

        public void UpdateTeacher(TeacherDTO newTeacher)
        {
            _TeacherRepository.UpdateTeacher(newTeacher);
        }

        public void RemoveTeacher(string ID_Teacher)
        {
            _TeacherRepository.RemoveTeacher(ID_Teacher);
        }
    }
}
