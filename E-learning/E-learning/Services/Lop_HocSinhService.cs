using E_learning.Entity;
using E_learning.Model;
using E_learning.Repositories;
using Microsoft.AspNetCore.Identity;

namespace E_learning.Services
{
    public class Lop_HocSinhService
    {
        private ILop_HocSinhRepository _lop_HocSinhRepository;
        public Lop_HocSinhService(ILop_HocSinhRepository lop_HocSinhRepository)
        {
            _lop_HocSinhRepository = lop_HocSinhRepository;
        }
        public List<Lop_HocSinh> GetLop_HocSinhs()
        {
            return _lop_HocSinhRepository.GetLop_HocSinhs();
        }

        public async void InsertLop_HocSinh(Lop_HocSinhModel newLop_HocSinh, UserManager<AspNetUser> userManager)
        {
            _lop_HocSinhRepository.InsertLop_HocSinh(newLop_HocSinh, userManager);
        }

        public void UpdateLop_HocSinh(Guid ID, LopModel newLop_HocSinh)
        {
            _lop_HocSinhRepository.UpdateLop_HocSinh(ID, newLop_HocSinh);
        }

        public void RemoveLop_HocSinh(Guid ID)
        {
            _lop_HocSinhRepository.RemoveLop_HocSinh(ID);
        }

    }
}
