using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning.Models
{
    public class Lop_Thi_KiemTra
    {
        [Key]
        public Guid ID { get; set; }

        [Required, DisplayName("Lớp")]
        public Lop Lop { get; set; }

        [Required, DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true), DisplayName("Ngày kiểm tra")]
        public DateTime NgayKiemTra { get; set; }

        [Required, DisplayName("Môn học")]
        public MonHoc MonHoc { get; set; }

        [Required, DisplayName("Hình thức")]
        public HinhThuc_Thi_KiemTra HinhThuc { get; set; }

        [Required, MaxLength(100), DisplayName("Nội dung")]
        public string NoiDung { get; set; }

        [Required, MaxLength(100), DisplayName("Chủ đề")]
        public string ChuDe { get; set; }
        public string MoTa { get; set; }

        [Required, DisplayName("Thời gian làm bài")]
        public int ThoiLuong { get; set; }

        [Required, DisplayName("Trạng thái")]
        public int Status { get; set; }

        [MaxLength(50)]
        public string FileTestName { get; set; }
    }
}
