using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning.Entity
{
    public class Lop_MonHoc
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public Guid ID_Lop { get; set; }

        [Required, ForeignKey("ID_Lop")]
        public Lop Lop { get; set; }

        [Required]
        public Guid ID_MonHoc { get; set; }

        [Required, ForeignKey("ID_MonHoc")]
        public MonHoc MonHoc { get; set; }

        [Required]
        public int ThoiLuongHoc { get; set; }

        [Required]
        public DateTime NgayBatDau { get; set; }

        [Required]
        public DateTime NgayKetThuc { get; set; }

        [Required, MaxLength(50)]
        public string BaoMat { get; set; }

        [Required, MaxLength(50)]
        public string Link { get; set; }

        [Required]
        public int Status { get; set; }

        [Required]
        public string ID_GiaoVien { get; set; }

        [Required,ForeignKey("ID_GiaoVien")]
        public AspNetUser GiaoVien { get; set; }
    }
}
