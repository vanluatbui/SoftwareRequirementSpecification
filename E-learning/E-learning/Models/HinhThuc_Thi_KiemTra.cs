using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_learning.Models
{
    public class HinhThuc_Thi_KiemTra
    {
        [Key, DisplayName("ID_HinhThuc")]
        public Guid ID_HinhThuc { get; set; }

        [Required, MaxLength(50), DisplayName("Tên hình thức")]
        public string TenHinhThuc { get; set; }
    }
}
