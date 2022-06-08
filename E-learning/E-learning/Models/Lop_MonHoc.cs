using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning.Models
{
    public class Lop_MonHoc
    {
        [Key]
        public Guid ID { get; set; }

        [Required, DisplayName("Lớp")]
        public Lop Lop { get; set; }

        [Required, DisplayName("Môn học")]
        public MonHoc MonHoc { get; set; }

        [Required]
        public int ThoiLuongHoc { get; set; }

        [Required, DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true), DisplayName("Ngày bắt đầu")]
        public DateTime NgayBatDau { get; set; }

        [Required, DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true), DisplayName("Ngày bắt đầu")]
        public DateTime NgayKetThuc { get; set; }

        [Required, MaxLength(50), DisplayName("Bảo mật")]
        public string BaoMat { get; set; }

        [Required, MaxLength(50), DisplayName("Link môn học của lớp")]
        public string Link { get; set; }

        [Required, DisplayName("Trạng thái")]
        public int Status { get; set; }

        [DisplayName("Giáo viên")]
        public AspNetUser GiaoVien { get; set; }
    }
}
