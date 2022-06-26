using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning.Entity
{
    public class Diem_HocSinh
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public string ID_HocSinh { get; set; }

        [Required,ForeignKey("ID_HocSinh")]
        public AspNetUser HocSinh { get; set; }

        [Required]
        public Guid ID_MonHoc { get; set; }

        [Required, ForeignKey("ID_MonHoc")]
        public MonHoc MonHoc { get; set; }

        [Required]
        public double DiemChuyenCan { get; set; }

        [Required]
        public double DiemMieng { get; set; }

        [Required]
        public double DiemHeSo2 { get; set; }

        [Required]
        public double DiemHeSo3 { get; set; }

        [Required]
        public double DiemTrungBinh { get; set; }

        [Required]
        public int DanhGia { get; set; }

        [Required]
        public DateTime NgayCapNhat { get; set; }
    }
}
