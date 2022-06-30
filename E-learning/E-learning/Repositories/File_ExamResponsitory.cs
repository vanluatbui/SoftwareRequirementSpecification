using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.DTO;
using E_learning.Entity;

namespace E_learning.Repositories
{
    public interface IFile_ExamRepository : IRepository<File_Exam>
    {
        List<File_ExamDTO> GetFile_Exams();
        void InsertFile_Exam(File_ExamDTO newFile_Exam);

        void UpdateFile_Exam(File_ExamDTO newFile_Exam);

        void RemoveFile_Exam(string ID_File_Exam);
    }

    public class File_ExamRespository : RepositoryBase<File_Exam>, IFile_ExamRepository
    {
        IMapper mapper;
        public File_ExamRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
            var config = new MapperConfiguration(cfg =>
            {
                Model_AutoMapper_Config.CreateMap(cfg);
            });

            mapper = config.CreateMapper();
        }

        public List<File_ExamDTO> GetFile_Exams()
        {
            List<File_Exam> listFile_Exam = _dbcontext.File_Exams.ToList();

            //Auto Mapper

            List<File_ExamDTO> listFile_ExamDTO = listFile_Exam.Select(emp => mapper.Map<File_Exam, File_ExamDTO>(emp)).ToList();

            return listFile_ExamDTO;

        }

        public void InsertFile_Exam(File_ExamDTO newFile_Exam)
        {
            // Auto Mapper

            File_Exam File_Exam = mapper.Map<File_ExamDTO, File_Exam>(newFile_Exam);

            _dbcontext.File_Exams.Add(File_Exam);
            _dbcontext.SaveChanges();
        }

        public void UpdateFile_Exam(File_ExamDTO newFile_Exam)
        {
            File_Exam File_Exam = _dbcontext.File_Exams.First(p => p.ID_File_Exam == newFile_Exam.ID_File_Exam);

            _dbcontext.Entry(File_Exam).CurrentValues.SetValues(newFile_Exam);

            _dbcontext.SaveChanges();
        }

        public void RemoveFile_Exam(string ID_File_Exam)
        {
            File_Exam File_Exam = _dbcontext.File_Exams.First(p => p.ID_File_Exam == ID_File_Exam);

            _dbcontext.File_Exams.Remove(File_Exam);

            _dbcontext.SaveChanges();
        }
    }
}
