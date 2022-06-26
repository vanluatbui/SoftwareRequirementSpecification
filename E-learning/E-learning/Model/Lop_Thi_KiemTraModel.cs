using E_learning.Entity;

namespace E_learning.Model
{
    public class Lop_Thi_KiemTraModel
    {
        public Guid ID_Lop { get; set; }
        public DateTime NgayKiemTra { get; set; }

        public Guid ID_MonHoc { get; set; }

        public Guid ID_HinhThuc { get; set; }

        public string NoiDung { get; set; }

        public string ChuDe { get; set; }

        public string MoTa { get; set; }

        public int ThoiLuong { get; set; }

        public int Status { get; set; }

        public string FileTestName { get; set; }
    }
}
