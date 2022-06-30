using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.DTO;
using E_learning.Entity;

namespace E_learning.Repositories
{
    public interface IStudent_TestRepository : IRepository<Student_Test>
    {
        List<Student_TestDTO> GetStudent_Tests();
        void InsertStudent_Test(Student_TestDTO newStudent_Test);

        void UpdateStudent_Test(Student_TestDTO newStudent_Test);

        void RemoveStudent_Test(string ID_Student, string ID_Class_Test);
    }

    public class Student_TestRespository : RepositoryBase<Student_Test>, IStudent_TestRepository
    {
        IMapper mapper;
        public Student_TestRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
            var config = new MapperConfiguration(cfg =>
            {
                Model_AutoMapper_Config.CreateMap(cfg);
            });

            mapper = config.CreateMapper();
        }

        public List<Student_TestDTO> GetStudent_Tests()
        {
            List<Student_Test> listStudent_Test = _dbcontext.Student_Tests.ToList();

            //Auto Mapper

            List<Student_TestDTO> listStudent_TestDTO = listStudent_Test.Select(emp => mapper.Map<Student_Test, Student_TestDTO>(emp)).ToList();

            return listStudent_TestDTO;

        }

        public void InsertStudent_Test(Student_TestDTO newStudent_Test)
        {
            // Auto Mapper

            Student_Test Student_Test = mapper.Map<Student_TestDTO, Student_Test>(newStudent_Test);

            _dbcontext.Student_Tests.Add(Student_Test);
            _dbcontext.SaveChanges();
        }

        public void UpdateStudent_Test(Student_TestDTO newStudent_Test)
        {
            Student_Test Student_Test = _dbcontext.Student_Tests.First(p => p.ID_Student == newStudent_Test.ID_Student
            && p.ID_Class_Test == newStudent_Test.ID_Class_Test);

            _dbcontext.Entry(Student_Test).CurrentValues.SetValues(newStudent_Test);

            _dbcontext.SaveChanges();
        }

        public void RemoveStudent_Test(string ID_Student, string ID_Class_Test)
        {
            Student_Test Student_Test = _dbcontext.Student_Tests.First(p => p.ID_Student == ID_Student 
            && p.ID_Class_Test == ID_Class_Test);

            _dbcontext.Student_Tests.Remove(Student_Test);

            _dbcontext.SaveChanges();
        }
    }
}
