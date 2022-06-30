using E_learning.DTO;
using E_learning.Entity;
using E_learning.Repositories;

namespace E_learning.Services
{
    public class ClassService
    {
        private IClassRepository _ClassRepository;
        public ClassService(IClassRepository ClassRepository)
        {
            _ClassRepository = ClassRepository;
        }
        public List<ClassDTO> GetClasss()
        {
            return _ClassRepository.GetClasss();
        }

        public void InsertClass(ClassDTO newClass)
        {
            _ClassRepository.InsertClass(newClass);
        }

        public void UpdateClass (ClassDTO newClass)
        {
            _ClassRepository.UpdateClass(newClass);
        }

        public void RemoveClass(string ID_Class)
        {
            _ClassRepository.RemoveClass(ID_Class);
        }
    }
}
