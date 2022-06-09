using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_learning.Entity
{
    public class MonHoc
    {
        [Key]
        public Guid ID_MonHoc { get; set; }

        [Required, MaxLength(50)]
        public string TenMonHoc { get; set; }

        [Required, MaxLength(100)]
        public string MoTa { get; set; }
    }
}
