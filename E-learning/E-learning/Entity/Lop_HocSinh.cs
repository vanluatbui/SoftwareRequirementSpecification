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
        public Guid ID_Lop { get; set; }

        [Required, ForeignKey("ID_Lop")]
        public Lop Lop { get; set; }

        [Required]
        public string ID_HocSinh { get; set; }

        [Required, ForeignKey("ID_HocSinh")]
        public AspNetUser HocSinh { get; set; }

        [Required]
        public DateTime NgayThamGia { get; set; }

    }
}
