using E_learning.Entity;

namespace E_learning.Model
{
    public class ThoiKhoaBieuModel
    {
        public Lop Lop { get; set; }
        public DateTime NgayHoc { get; set; }
        public int SoTiet { get; set; }

        public MonHoc MonHoc { get; set; }
    }
}
