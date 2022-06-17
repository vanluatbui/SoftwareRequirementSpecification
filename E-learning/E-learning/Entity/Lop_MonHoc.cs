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
        public Lop Lop { get; set; }

        [Required]
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

        public AspNetUser GiaoVien { get; set; }
    }
}
