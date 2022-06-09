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

        [Required, DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime NgayBatDau { get; set; }

        [Required, DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime NgayKetThuc { get; set; }

        [Required]
        public int ThoiLuongHoc { get; set; }

        [Required]
        public int Status { get; set; }

        [Required]
        public string BaoMat { get; set; }

        [Required]
        public string Link { get; set; }

        public AspNetUser GiaoVien { get; set; }

        [Required]
        public KhoaHoc KhoaHoc { get; set; }
    }
}
