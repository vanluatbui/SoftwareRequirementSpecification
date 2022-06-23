using E_learning.Entity;
using E_learning.Model;
using E_learning.Repositories;

namespace E_learning.Services
{
    public class Diem_HocSinhService
    {
        private IDiem_HocSinhRepository _Diem_HocSinhRepository;
        public Diem_HocSinhService(IDiem_HocSinhRepository Diem_HocSinhRepository)
        {
            _Diem_HocSinhRepository = Diem_HocSinhRepository;
        }
        public List<Diem_HocSinh> GetDiem_HocSinhs()
        {
            return _Diem_HocSinhRepository.GetDiem_HocSinhs();
        }

        public void InsertDiem_HocSinh(Diem_HocSinhModel newKQ)
        {
            _Diem_HocSinhRepository.InsertDiem_HocSinh(newKQ);
        }

        public void UpdateDiem_HocSinh (Guid ID_Diem_HocSinh, Diem_HocSinhModel newKQ)
        {
            _Diem_HocSinhRepository.UpdateDiem_HocSinh(ID_Diem_HocSinh, newKQ);
        }

        public void RemoveDiem_HocSinh(Guid ID_Diem_HocSinh)
        {
            _Diem_HocSinhRepository.RemoveDiem_HocSinh(ID_Diem_HocSinh);
        }
    }
}
