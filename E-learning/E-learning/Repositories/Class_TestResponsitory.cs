using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.DTO;
using E_learning.Entity;

namespace E_learning.Repositories
{
    public interface IClass_TestRepository : IRepository<Class_Test>
    {
        List<Class_TestDTO> GetClass_Tests();
        void InsertClass_Test(Class_TestDTO newClass_Test);

        void UpdateClass_Test(Class_TestDTO newClass_Test);

        void RemoveClass_Test(string ID_Class_Test);
    }

    public class Class_TestRespository : RepositoryBase<Class_Test>, IClass_TestRepository
    {
        IMapper mapper;
        public Class_TestRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
            var config = new MapperConfiguration(cfg =>
            {
                Model_AutoMapper_Config.CreateMap(cfg);
            });

            mapper = config.CreateMapper();
        }

        public List<Class_TestDTO> GetClass_Tests()
        {
            List<Class_Test> listClass_Test = _dbcontext.Class_Tests.ToList();

            //Auto Mapper

            List<Class_TestDTO> listClass_TestDTO = listClass_Test.Select(emp => mapper.Map<Class_Test, Class_TestDTO>(emp)).ToList();

            return listClass_TestDTO;

        }

        public void InsertClass_Test(Class_TestDTO newClass_Test)
        {
            // Auto Mapper

            Class_Test Class_Test = mapper.Map<Class_TestDTO, Class_Test>(newClass_Test);

            _dbcontext.Class_Tests.Add(Class_Test);
            _dbcontext.SaveChanges();
        }

        public void UpdateClass_Test(Class_TestDTO newClass_Test)
        {
            Class_Test Class_Test = _dbcontext.Class_Tests.First(p => p.ID_Class_Test == newClass_Test.ID_Class_Test);

            _dbcontext.Entry(Class_Test).CurrentValues.SetValues(newClass_Test);

            _dbcontext.SaveChanges();
        }

        public void RemoveClass_Test(string ID_Class_Test)
        {
            Class_Test Class_Test = _dbcontext.Class_Tests.First(p => p.ID_Class_Test == ID_Class_Test);

            _dbcontext.Class_Tests.Remove(Class_Test);

            _dbcontext.SaveChanges();
        }
    }
}
