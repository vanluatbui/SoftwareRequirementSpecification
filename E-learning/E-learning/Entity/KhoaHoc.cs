using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_learning.Entity
{
    public class KhoaHoc
    {
        [Key]
        public Guid ID_KhoaHoc { get; set; }

        [Required]
        public string TenKhoaHoc { get; set; }

        [Required,
         MaxLength(9, ErrorMessage = "Niên khoá học chỉ có thể tối đa 9 kí tự (ví dụ : 2021-2022) !")
        ]
        public string NienKhoaHoc { get; set; }
    }
}
