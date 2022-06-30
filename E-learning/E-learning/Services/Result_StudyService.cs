using E_learning.DTO;
using E_learning.Entity;
using E_learning.Repositories;

namespace E_learning.Services
{
    public class Result_StudyService
    {
        private IResult_StudyRepository _Result_StudyRepository;
        public Result_StudyService(IResult_StudyRepository Result_StudyRepository)
        {
            _Result_StudyRepository = Result_StudyRepository;
        }
        public List<Result_StudyDTO> GetResult_Studys()
        {
            return _Result_StudyRepository.GetResult_Studys();
        }

        public void InsertResult_Study(Result_StudyDTO newResult_Study)
        {
            _Result_StudyRepository.InsertResult_Study(newResult_Study);
        }

        public void UpdateResult_Study (Result_StudyDTO newResult_Study)
        {
            _Result_StudyRepository.UpdateResult_Study(newResult_Study);
        }

        public void RemoveResult_Study(string ID_Student, string ID_Subject)
        {
            _Result_StudyRepository.RemoveResult_Study(ID_Student, ID_Subject);
        }
    }
}
