using E_learning.DTO;
using E_learning.Entity;
using E_learning.Repositories;

namespace E_learning.Services
{
    public class File_ExamService
    {
        private IFile_ExamRepository _File_ExamRepository;
        public File_ExamService(IFile_ExamRepository File_ExamRepository)
        {
            _File_ExamRepository = File_ExamRepository;
        }
        public List<File_ExamDTO> GetFile_Exams()
        {
            return _File_ExamRepository.GetFile_Exams();
        }

        public void InsertFile_Exam(File_ExamDTO newFile_Exam)
        {
            _File_ExamRepository.InsertFile_Exam(newFile_Exam);
        }

        public void UpdateFile_Exam (File_ExamDTO newFile_Exam)
        {
            _File_ExamRepository.UpdateFile_Exam(newFile_Exam);
        }

        public void RemoveFile_Exam(string ID_File_Exam)
        {
            _File_ExamRepository.RemoveFile_Exam(ID_File_Exam);
        }
    }
}
