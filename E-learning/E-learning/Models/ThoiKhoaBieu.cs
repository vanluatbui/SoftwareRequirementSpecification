using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning.Models
{
    public class ThoiKhoaBieu
    {
        [Key]
        public Guid ID { get; set; }

        [Required, DisplayName("Lớp")]
        public Lop Lop { get; set; }

        [Required,
        MaxLength(12, ErrorMessage = "Thời gian học bắt đầu của một môn học chỉ có thể tối đa 12 kí tự (ví dụ : Thứ 5-09:30) !"),
        DisplayName("Thời gian học")
       ]
        public string ThoiGianHoc { get; set; } // Thứ mấy, bắt đầu lúc mấy giờ?

        [Required, DisplayName("Số tiết")]
        public int SoTiet { get; set; }

        [Required, DisplayName("Môn học")]
        public MonHoc MonHoc { get; set; }
    }
}
