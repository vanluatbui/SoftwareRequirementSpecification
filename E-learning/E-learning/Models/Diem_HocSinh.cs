using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning.Models
{
    public class Diem_HocSinh
    {
        [Key]
        public Guid ID { get; set; }

        [Required, DisplayName("Học sinh")]
        public AspNetUser HocSinh { get; set; }

        [Required, DisplayName("Môn học")]
        public MonHoc MonHoc { get; set; }

        [Required, DisplayName("Điểm chuyên cần")]
        public double DiemChuyenCan { get; set; }

        [Required, DisplayName("Điểm miệng")]
        public double DiemMieng { get; set; }

        [Required, DisplayName("Điểm hệ số 2")]
        public double DiemHeSo2 { get; set; }

        [Required, DisplayName("Điểm hệ số 3")]
        public double DiemHeSo3 { get; set; }

        [Required, DisplayName("Điểm trung bình")]
        public double DiemTrungBinh { get; set; }

        [Required, DisplayName("Xếp loại")]
        public int DanhGia { get; set; }

        [Required, DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true), DisplayName("Ngày cập nhật")]
        public DateTime NgayCapNhat { get; set; }
    }
}
