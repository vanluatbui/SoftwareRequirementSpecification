using System.ComponentModel.DataAnnotations;

namespace SoftwareRequirementSpecification.Models
{
    public class Diem_SinhVien
    {
        [Key]
        public Guid ID { get; set; }
        public User SinhVien { get; set; }
        public DateTime NgayKiemTra { get; set; }
        public Lop Lop { get; set; }
        public MonHoc MonHoc { get; set; }
        public HinhThuc_Thi_KiemTra HinhThuc { get; set; }
        public string FilePath { get; set; }
        public double Diem { get; set; }
        public string NhanXet { get; set; }
    }
}
