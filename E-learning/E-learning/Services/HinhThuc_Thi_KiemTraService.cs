using E_learning.Entity;
using E_learning.Model;
using E_learning.Repositories;

namespace E_learning.Services
{
    public class HinhThuc_Thi_KiemTraService
    {
        private IHinhThuc_Thi_KiemTraRepository _HinhThuc_Thi_KiemTraRepository;
        public HinhThuc_Thi_KiemTraService(IHinhThuc_Thi_KiemTraRepository HinhThuc_Thi_KiemTraRepository)
        {
            _HinhThuc_Thi_KiemTraRepository = HinhThuc_Thi_KiemTraRepository;
        }
        public List<HinhThuc_Thi_KiemTra> GetHinhThuc_Thi_KiemTras()
        {
            return _HinhThuc_Thi_KiemTraRepository.GetHinhThuc_Thi_KiemTras();
        }

        public void InsertHinhThuc_Thi_KiemTra(HinhThuc_Thi_KiemTraModel newHT)
        {
            _HinhThuc_Thi_KiemTraRepository.InsertHinhThuc_Thi_KiemTra(newHT);
        }

        public void UpdateHinhThuc_Thi_KiemTra (Guid ID_HinhThuc_Thi_KiemTra, HinhThuc_Thi_KiemTraModel newHT)
        {
            _HinhThuc_Thi_KiemTraRepository.UpdateHinhThuc_Thi_KiemTra(ID_HinhThuc_Thi_KiemTra, newHT);
        }

        public void RemoveHinhThuc_Thi_KiemTra(Guid ID_HinhThuc_Thi_KiemTra)
        {
            _HinhThuc_Thi_KiemTraRepository.RemoveHinhThuc_Thi_KiemTra(ID_HinhThuc_Thi_KiemTra);
        }
    }
}
