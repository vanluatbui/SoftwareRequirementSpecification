using E_learning.DTO;
using E_learning.Entity;
using E_learning.Repositories;

namespace E_learning.Services
{
    public class SubjectService
    {
        private ISubjectRepository _SubjectRepository;
        public SubjectService(ISubjectRepository SubjectRepository)
        {
            _SubjectRepository = SubjectRepository;
        }
        public List<SubjectDTO> GetSubjects()
        {
            return _SubjectRepository.GetSubjects();
        }

        public void InsertSubject(SubjectDTO newSubject)
        {
            _SubjectRepository.InsertSubject(newSubject);
        }

        public void UpdateSubject (SubjectDTO newSubject)
        {
            _SubjectRepository.UpdateSubject(newSubject);
        }

        public void RemoveSubject(string ID_Subject)
        {
            _SubjectRepository.RemoveSubject(ID_Subject);
        }
    }
}
