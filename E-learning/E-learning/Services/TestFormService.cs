using E_learning.DTO;
using E_learning.Entity;
using E_learning.Repositories;

namespace E_learning.Services
{
    public class TestFormService
    {
        private ITestFormRepository _TestFormRepository;
        public TestFormService(ITestFormRepository TestFormRepository)
        {
            _TestFormRepository = TestFormRepository;
        }
        public List<TestFormDTO> GetTestForms()
        {
            return _TestFormRepository.GetTestForms();
        }

        public void InsertTestForm(TestFormDTO newTestForm)
        {
            _TestFormRepository.InsertTestForm(newTestForm);
        }

        public void UpdateTestForm (TestFormDTO newTestForm)
        {
            _TestFormRepository.UpdateTestForm(newTestForm);
        }

        public void RemoveTestForm(string ID_TestForm)
        {
            _TestFormRepository.RemoveTestForm(ID_TestForm);
        }
    }
}
