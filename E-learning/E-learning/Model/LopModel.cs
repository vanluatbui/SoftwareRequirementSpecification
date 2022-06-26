
using E_learning.Entity;

namespace E_learning.Model
{
    public class LopModel
    {
        public Guid ID_Lop { get; set; }
        public string TenLop { get; set; }
        public string ChuDe { get; set; }

        public string MoTa { get; set; }

        public DateTime NgayBatDau { get; set; }

        public DateTime NgayKetThuc { get; set; }
        public int ThoiLuongHoc { get; set; }

        public int Status { get; set; }

        public string BaoMat { get; set; }

        public string Link { get; set; }
        public string username_GiaoVien { get; set; }
        public Guid ID_KhoaHoc { get; set; }
    }
}
