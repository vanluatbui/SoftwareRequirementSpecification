using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_learning.Entity
{
    public class HinhThuc_Thi_KiemTra
    {
        [Key]
        public Guid ID_HinhThuc { get; set; }

        [Required, MaxLength(50)]
        public string TenHinhThuc { get; set; }
    }
}
