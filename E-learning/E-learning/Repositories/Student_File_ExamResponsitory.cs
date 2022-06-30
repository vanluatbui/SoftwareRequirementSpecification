using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.DTO;
using E_learning.Entity;

namespace E_learning.Repositories
{
    public interface IStudent_File_ExamRepository : IRepository<Student_File_Exam>
    {
        List<Student_File_ExamDTO> GetStudent_File_Exams();
        void InsertStudent_File_Exam(Student_File_ExamDTO newStudent_File_Exam);

        void UpdateStudent_File_Exam(Student_File_ExamDTO newStudent_File_Exam);

        void RemoveStudent_File_Exam(string ID_Student_File_Exam);
    }

    public class Student_File_ExamRespository : RepositoryBase<Student_File_Exam>, IStudent_File_ExamRepository
    {
        IMapper mapper;
        public Student_File_ExamRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
            var config = new MapperConfiguration(cfg =>
            {
                Model_AutoMapper_Config.CreateMap(cfg);
            });

            mapper = config.CreateMapper();
        }

        public List<Student_File_ExamDTO> GetStudent_File_Exams()
        {
            List<Student_File_Exam> listStudent_File_Exam = _dbcontext.Student_File_Exams.ToList();

            //Auto Mapper

            List<Student_File_ExamDTO> listStudent_File_ExamDTO = listStudent_File_Exam.Select(emp => mapper.Map<Student_File_Exam, Student_File_ExamDTO>(emp)).ToList();

            return listStudent_File_ExamDTO;

        }

        public void InsertStudent_File_Exam(Student_File_ExamDTO newStudent_File_Exam)
        {
            // Auto Mapper

            Student_File_Exam Student_File_Exam = mapper.Map<Student_File_ExamDTO, Student_File_Exam>(newStudent_File_Exam);

            _dbcontext.Student_File_Exams.Add(Student_File_Exam);
            _dbcontext.SaveChanges();
        }

        public void UpdateStudent_File_Exam(Student_File_ExamDTO newStudent_File_Exam)
        {
            Student_File_Exam Student_File_Exam = _dbcontext.Student_File_Exams.First(p => p.ID_Student_File_Exam == newStudent_File_Exam.ID_Student_File_Exam);

            _dbcontext.Entry(Student_File_Exam).CurrentValues.SetValues(newStudent_File_Exam);

            _dbcontext.SaveChanges();
        }

        public void RemoveStudent_File_Exam(string ID_Student_File_Exam)
        {
            Student_File_Exam Student_File_Exam = _dbcontext.Student_File_Exams.First(p => p.ID_Student_File_Exam == ID_Student_File_Exam);

            _dbcontext.Student_File_Exams.Remove(Student_File_Exam);

            _dbcontext.SaveChanges();
        }
    }
}
