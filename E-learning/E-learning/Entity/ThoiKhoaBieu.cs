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
        public Lop Lop { get; set; }

        [Required]
        public DateTime NgayHoc { get; set; } 

        [Required]
        public int SoTiet { get; set; }

        [Required]
        public MonHoc MonHoc { get; set; }
    }
}
