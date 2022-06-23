using E_learning.Entity;
using E_learning.Model;
using E_learning.Repositories;

namespace E_learning.Services
{
    public class Lop_Thi_KiemTraService
    {
        private ILop_Thi_KiemTraRepository _Lop_Thi_KiemTraRepository;
        public Lop_Thi_KiemTraService(ILop_Thi_KiemTraRepository Lop_Thi_KiemTraRepository)
        {
            _Lop_Thi_KiemTraRepository = Lop_Thi_KiemTraRepository;
        }
        public List<Lop_Thi_KiemTra> GetLop_Thi_KiemTras()
        {
            return _Lop_Thi_KiemTraRepository.GetLop_Thi_KiemTras();
        }

        public void InsertLop_Thi_KiemTra(Lop_Thi_KiemTraModel newKT)
        {
            _Lop_Thi_KiemTraRepository.InsertLop_Thi_KiemTra(newKT);
        }

        public void UpdateLop_Thi_KiemTra (Guid ID_Lop_Thi_KiemTra, Lop_Thi_KiemTraModel newKT)
        {
            _Lop_Thi_KiemTraRepository.UpdateLop_Thi_KiemTra(ID_Lop_Thi_KiemTra, newKT);
        }

        public void RemoveLop_Thi_KiemTra(Guid ID_Lop_Thi_KiemTra)
        {
            _Lop_Thi_KiemTraRepository.RemoveLop_Thi_KiemTra(ID_Lop_Thi_KiemTra);
        }
    }
}
