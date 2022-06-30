using E_learning.DTO;
using E_learning.Entity;
using E_learning.Repositories;

namespace E_learning.Services
{
    public class Class_TestService
    {
        private IClass_TestRepository _Class_TestRepository;
        public Class_TestService(IClass_TestRepository Class_TestRepository)
        {
            _Class_TestRepository = Class_TestRepository;
        }
        public List<Class_TestDTO> GetClass_Tests()
        {
            return _Class_TestRepository.GetClass_Tests();
        }

        public void InsertClass_Test(Class_TestDTO newClass_Test)
        {
            _Class_TestRepository.InsertClass_Test(newClass_Test);
        }

        public void UpdateClass_Test (Class_TestDTO newClass_Test)
        {
            _Class_TestRepository.UpdateClass_Test(newClass_Test);
        }

        public void RemoveClass_Test(string ID_Class_Test)
        {
            _Class_TestRepository.RemoveClass_Test(ID_Class_Test);
        }
    }
}
