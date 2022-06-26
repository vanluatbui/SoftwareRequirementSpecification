using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning.Entity
{
    public class Lop
    {
        [Key]
        public Guid ID_Lop { get; set; }

        [Required,MaxLength(50)]
        public string TenLop { get; set; }

        [MaxLength(100)]
        public string ChuDe { get; set; }

        [MaxLength(100)]
        public string MoTa { get; set; }

        [Required]
        public DateTime NgayBatDau { get; set; }

        [Required]
        public DateTime NgayKetThuc { get; set; }

        [Required]
        public int ThoiLuongHoc { get; set; }

        [Required]
        public int Status { get; set; }

        [Required]
        public string BaoMat { get; set; }

        [Required]
        public string Link { get; set; }

        [Required]
        public string ID_GiaoVien { get; set; }

        [Required, ForeignKey("ID_GiaoVien")]
        public AspNetUser GiaoVien{ get; set; }

        [Required]
        public Guid ID_KhoaHoc { get; set; }

        [Required, ForeignKey("ID_KhoaHoc")]
        public KhoaHoc KhoaHoc { get; set; }
    }
}
