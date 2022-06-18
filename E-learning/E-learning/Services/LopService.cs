using E_learning.Entity;
using E_learning.Model;
using E_learning.Repositories;
using Microsoft.AspNetCore.Identity;

namespace E_learning.Services
{
    public class LopService
    {
        private ILopRepository _lopRepository;
        public LopService(ILopRepository lopRepository)
        {
            _lopRepository = lopRepository;
        }
        public List<Lop> GetLops()
        {
            return _lopRepository.GetLops();
        }

        public async void InsertLop(LopModel newLop)
        {
            _lopRepository.InsertLop(newLop);
        }

        public async void UpdateLop(Guid ID_Lop, LopModel newLop)
        {
            _lopRepository.UpdateLop(ID_Lop, newLop);
        }

        public void RemoveLop(Guid ID_Lop)
        {
            _lopRepository.RemoveLop(ID_Lop);
        }
    }
}
