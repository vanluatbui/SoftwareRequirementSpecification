using E_learning.Entity;
using E_learning.Model;
using E_learning.Repositories;

namespace E_learning.Services
{
    public class MonHocService
    {
        private IMonHocRepository _MonHocRepository;
        public MonHocService(IMonHocRepository MonHocRepository)
        {
            _MonHocRepository = MonHocRepository;
        }
        public List<MonHoc> GetMonHocs()
        {
            return _MonHocRepository.GetMonHocs();
        }

        public void InsertMonHoc(MonHocModel newMH)
        {
            _MonHocRepository.InsertMonHoc(newMH);
        }

        public void UpdateMonHoc (Guid ID_MonHoc, MonHocModel newMH)
        {
            _MonHocRepository.UpdateMonHoc(ID_MonHoc, newMH);
        }

        public void RemoveMonHoc(Guid ID_MonHoc)
        {
            _MonHocRepository.RemoveMonHoc(ID_MonHoc);
        }
    }
}
