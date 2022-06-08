using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning.Models
{
    public class Lop
    {
        [Key,DisplayName("ID_Lop")]
        public Guid ID_Lop { get; set; }

        [Required,MaxLength(50),DisplayName("Tên lớp")]
        public string TenLop { get; set; }

        [Required,MaxLength(100),DisplayName("Chủ đề")]
        public string ChuDe { get; set; }

        [Required,MaxLength(100),DisplayName("Mô tả")]
        public string MoTa { get; set; }

        [Required, DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true), DisplayName("Ngày bắt đầu")]
        public DateTime NgayBatDau { get; set; }

        [Required, DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true), DisplayName("Ngày kết thúc")]
        public DateTime NgayKetThuc { get; set; }

        [Required, DisplayName("Thời lượng học")]
        public int ThoiLuongHoc { get; set; }

        [Required, DisplayName("Trạng thái")]
        public int Status { get; set; }

        [Required,MaxLength(50),DisplayName("Bảo mật")]
        public string BaoMat { get; set; }

        [Required, MaxLength(50), DisplayName("Link lớp học")]
        public string Link { get; set; }

        [DisplayName("Giáo viên")]
        public AspNetUser GiaoVien { get; set; }

        [Required,DisplayName("Khoá học")]
        public KhoaHoc KhoaHoc { get; set; }
    }
}
