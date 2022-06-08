using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_learning.Models
{
    public class KhoaHoc
    {
        [Key,DisplayName("ID_KhoaHoc")]
        public Guid ID_KhoaHoc { get; set; }

        [Required,MaxLength(50),DisplayName("Tên khoá học")]
        public string TenKhoaHoc { get; set; }

        [Required,
         MaxLength(9, ErrorMessage = "Niên khoá học chỉ có thể tối đa 9 kí tự (ví dụ : 2021-2022) !"),
         DisplayName("Niên khoá")
        ]
        public string NienKhoaHoc { get; set; }
    }
}
