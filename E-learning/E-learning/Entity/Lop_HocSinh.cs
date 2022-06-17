using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning.Entity
{
    public class Lop_HocSinh
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public Lop Lop { get; set; }

        [Required]
        public AspNetUser HocSinh { get; set; }

        [Required]
        public DateTime NgayThamGia { get; set; }

    }
}
