using E_learning.DTO;
using E_learning.Entity;
using E_learning.Repositories;

namespace E_learning.Services
{
    public class SemesterService
    {
        private ISemesterRepository _SemesterRepository;
        public SemesterService(ISemesterRepository SemesterRepository)
        {
            _SemesterRepository = SemesterRepository;
        }
        public List<SemesterDTO> GetSemesters()
        {
            return _SemesterRepository.GetSemesters();
        }

        public void InsertSemester(SemesterDTO newSemester)
        {
            _SemesterRepository.InsertSemester(newSemester);
        }

        public void UpdateSemester (SemesterDTO newSemester)
        {
            _SemesterRepository.UpdateSemester(newSemester);
        }

        public void RemoveSemester(string ID_Semester)
        {
            _SemesterRepository.RemoveSemester(ID_Semester);
        }
    }
}
