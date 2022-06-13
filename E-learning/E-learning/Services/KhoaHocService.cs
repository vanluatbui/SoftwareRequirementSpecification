using E_learning.Entity;
using E_learning.Model;
using E_learning.Repositories;

namespace E_learning.Services
{
    public class KhoaHocService
    {
        private IKhoaHocRepository _khoahocRepository;
        public KhoaHocService(IKhoaHocRepository khoahocRepository)
        {
            _khoahocRepository = khoahocRepository;
        }
        public List<KhoaHoc> GetKhoaHocs()
        {
            return _khoahocRepository.GetKhoaHocs();
        }

        public void InsertKhoaHoc(KhoaHocModel newKH)
        {
            _khoahocRepository.InsertKhoaHoc(newKH);
        }

        public void UpdateKhoaHoc (Guid ID_KhoaHoc, KhoaHocModel newKH)
        {
            _khoahocRepository.UpdateKhoaHoc(ID_KhoaHoc, newKH);
        }

        public void RemoveKhoaHoc(Guid ID_KhoaHoc)
        {
            _khoahocRepository.RemoveKhoaHoc(ID_KhoaHoc);
        }
    }
}
