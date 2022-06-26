using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning.Entity
{
    public class ThoiKhoaBieu
    {
       [Key]
       public Guid ID { get; set; }

        [Required]
        public Guid ID_Lop { get; set; }

        [Required, ForeignKey("ID_Lop")]
        public Lop Lop { get; set; }

        [Required]
        public DateTime NgayHoc { get; set; } 

        [Required]
        public int SoTiet { get; set; }

        [Required]
        public Guid ID_MonHoc { get; set; }

        [Required, ForeignKey("ID_MonHoc")]
        public MonHoc MonHoc { get; set; }
    }
}
