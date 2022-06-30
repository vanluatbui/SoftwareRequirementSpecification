using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.DTO;
using E_learning.Entity;

namespace E_learning.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {
        List<StudentDTO> GetStudents();
        void InsertStudent(StudentDTO newStudent);

        void UpdateStudent(StudentDTO newStudent);

        void RemoveStudent(string ID_Student);
    }

    public class StudentRespository : RepositoryBase<Student>, IStudentRepository
    {
        IMapper mapper;
        public StudentRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
            var config = new MapperConfiguration(cfg =>
            {
                Model_AutoMapper_Config.CreateMap(cfg);
            });

            mapper = config.CreateMapper();
        }

        public List<StudentDTO> GetStudents()
        {
            List<Student> listStudent = _dbcontext.Students.ToList();

            //Auto Mapper

            List<StudentDTO> listStudentDTO = listStudent.Select(emp => mapper.Map<Student, StudentDTO>(emp)).ToList();

            return listStudentDTO;

        }

        public void InsertStudent(StudentDTO newStudent)
        {
            // Auto Mapper

            Student Student = mapper.Map<StudentDTO, Student>(newStudent);

            _dbcontext.Students.Add(Student);
            _dbcontext.SaveChanges();
        }

        public void UpdateStudent(StudentDTO newStudent)
        {
            Student Student = _dbcontext.Students.First(p => p.ID_Student == newStudent.ID_Student);

            _dbcontext.Entry(Student).CurrentValues.SetValues(newStudent);

            _dbcontext.SaveChanges();
        }

        public void RemoveStudent(string ID_Student)
        {
            Student Student = _dbcontext.Students.First(p => p.ID_Student == ID_Student);

            _dbcontext.Students.Remove(Student);

            _dbcontext.SaveChanges();
        }
    }
}
