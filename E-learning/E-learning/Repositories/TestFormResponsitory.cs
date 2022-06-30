using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Data;
using E_learning.DTO;
using E_learning.Entity;

namespace E_learning.Repositories
{
    public interface ITestFormRepository : IRepository<TestForm>
    {
        List<TestFormDTO> GetTestForms();
        void InsertTestForm(TestFormDTO newTestForm);

        void UpdateTestForm(TestFormDTO newTestForm);

        void RemoveTestForm(string ID_TestForm);
    }

    public class TestFormRespository : RepositoryBase<TestForm>, ITestFormRepository
    {
        IMapper mapper;
        public TestFormRespository(ApplicationDbContext dbContext) : base(dbContext)
        {
            var config = new MapperConfiguration(cfg =>
            {
                Model_AutoMapper_Config.CreateMap(cfg);
            });

            mapper = config.CreateMapper();
        }

        public List<TestFormDTO> GetTestForms()
        {
            List<TestForm> listTestForm = _dbcontext.TestForms.ToList();

            //Auto Mapper

            List<TestFormDTO> listTestFormDTO = listTestForm.Select(emp => mapper.Map<TestForm, TestFormDTO>(emp)).ToList();

            return listTestFormDTO;

        }

        public void InsertTestForm(TestFormDTO newTestForm)
        {
            // Auto Mapper

            TestForm TestForm = mapper.Map<TestFormDTO, TestForm>(newTestForm);

            _dbcontext.TestForms.Add(TestForm);
            _dbcontext.SaveChanges();
        }

        public void UpdateTestForm(TestFormDTO newTestForm)
        {
            TestForm TestForm = _dbcontext.TestForms.First(p => p.ID_TestForm == newTestForm.ID_TestForm);

            _dbcontext.Entry(TestForm).CurrentValues.SetValues(newTestForm);

            _dbcontext.SaveChanges();
        }

        public void RemoveTestForm(string ID_TestForm)
        {
            TestForm TestForm = _dbcontext.TestForms.First(p => p.ID_TestForm == ID_TestForm);

            _dbcontext.TestForms.Remove(TestForm);

            _dbcontext.SaveChanges();
        }
    }
}
