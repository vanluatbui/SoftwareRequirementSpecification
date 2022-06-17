using E_learning.Entity;
using E_learning.Model;
using E_learning.Repositories;
using Microsoft.AspNetCore.Identity;

namespace E_learning.Services
{
    public class Lop_MonHocService
    {
        private ILop_MonHocRepository _Lop_MonHocRepository;
        public Lop_MonHocService(ILop_MonHocRepository Lop_MonHocRepository)
        {
            _Lop_MonHocRepository = Lop_MonHocRepository;
        }
        public List<Lop_MonHoc> GetLop_MonHocs()
        {
            return _Lop_MonHocRepository.GetLop_MonHocs();
        }

        public async void InsertLop_MonHoc(Lop_MonHocModel newLop_MonHoc, UserManager<AspNetUser> userManager)
        {
            _Lop_MonHocRepository.InsertLop_MonHoc(newLop_MonHoc, userManager);
        }

        public void UpdateLop_MonHoc(Guid ID, Lop_MonHocModel newLop_MonHoc, UserManager<AspNetUser> userManager)
        {
            _Lop_MonHocRepository.UpdateLop_MonHoc(ID, newLop_MonHoc, userManager);
        }

        public void RemoveLop_MonHoc(Guid ID)
        {
            _Lop_MonHocRepository.RemoveLop_MonHoc(ID);
        }

    }
}
