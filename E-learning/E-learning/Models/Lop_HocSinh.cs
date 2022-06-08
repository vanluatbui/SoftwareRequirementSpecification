using E_learning.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning.Models
{
    public class Lop_HocSinh
    {
        [Key]
        public Guid ID { get; set; }

        [Required, DisplayName("Lớp")]
        public Lop Lop { get; set; }

        [Required, DisplayName("Học sinh")]
        public AspNetUser HocSinh { get; set; }

        [Required, DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true), DisplayName("Ngày tham gia")]
        public DateTime NgayThamGia { get; set; }

    }
}
