using E_learning.Entity;

namespace E_learning.Model
{
    public class ThoiKhoaBieuModel
    {
        public Guid ID_Lop { get; set; }
        public DateTime NgayHoc { get; set; }
        public int SoTiet { get; set; }

        public Guid ID_MonHoc { get; set; }
    }
}
