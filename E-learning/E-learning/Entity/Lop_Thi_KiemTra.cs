﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning.Entity
{
    public class Lop_Thi_KiemTra
    {
          [Key]
         public Guid ID { get; set; }

        [Required]
        public Lop Lop { get; set; }

        [Required, DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime NgayKiemTra { get; set; }

        [Required]
        public MonHoc MonHoc { get; set; }

        [Required]
        public HinhThuc_Thi_KiemTra HinhThuc { get; set; }

        [Required, MaxLength(100)]
        public string NoiDung { get; set; }

        [MaxLength(100)]
        public string ChuDe { get; set; }

        [MaxLength(100)]
        public string MoTa { get; set; }

        [Required]
        public int ThoiLuong { get; set; }

        [Required]
        public int Status { get; set; }

        [MaxLength(50)]
        public string FileTestName { get; set; }
    }
}