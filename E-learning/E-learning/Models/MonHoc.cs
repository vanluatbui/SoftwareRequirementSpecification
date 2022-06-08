using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_learning.Models
{
    public class MonHoc
    {
        [Key, DisplayName("ID_MonHoc")]
        public Guid ID_MonHoc { get; set; }

        [Required, MaxLength(50), DisplayName("Tên môn học")]
        public string TenMonHoc { get; set; }

        [Required, MaxLength(100), DisplayName("Mô tả")]
        public string MoTa { get; set; }
    }
}
