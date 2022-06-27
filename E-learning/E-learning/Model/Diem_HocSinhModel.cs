using E_learning.Entity;

namespace E_learning.Model
{
    public class Diem_HocSinhModel
    {
        public Guid ID_HocSinh { get; set; }

        public Guid ID_MonHoc { get; set; }

        public double DiemChuyenCan { get; set; }

        public double DiemMieng { get; set; }
        public double DiemHeSo2 { get; set; }

        public double DiemHeSo3 { get; set; }
        public double DiemTrungBinh { get; set; }

        public int DanhGia { get; set; }
        public DateTime NgayCapNhat { get; set; }
    }
}
