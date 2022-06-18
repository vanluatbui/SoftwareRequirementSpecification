using E_learning.Entity;
using E_learning.Model;
using E_learning.Repositories;
using Microsoft.AspNetCore.Identity;

namespace E_learning.Services
{
    public class ThoiKhoaBieuService
    {
        private IThoiKhoaBieuRepository _ThoiKhoaBieuRepository;
        public ThoiKhoaBieuService(IThoiKhoaBieuRepository ThoiKhoaBieuRepository)
        {
            _ThoiKhoaBieuRepository = ThoiKhoaBieuRepository;
        }
        public List<ThoiKhoaBieu> GetThoiKhoaBieus()
        {
            return _ThoiKhoaBieuRepository.GetThoiKhoaBieus();
        }

        public async void InsertThoiKhoaBieu(ThoiKhoaBieuModel newThoiKhoaBieu)
        {
            _ThoiKhoaBieuRepository.InsertThoiKhoaBieu(newThoiKhoaBieu);
        }

        public void UpdateThoiKhoaBieu(Guid ID, ThoiKhoaBieuModel newThoiKhoaBieu)
        {
            _ThoiKhoaBieuRepository.UpdateThoiKhoaBieu(ID, newThoiKhoaBieu);
        }

        public void RemoveThoiKhoaBieu(Guid ID)
        {
            _ThoiKhoaBieuRepository.RemoveThoiKhoaBieu(ID);
        }

    }
}
