﻿namespace E_learning.Model
{
    public class Lop_MonHocModel
    {
        public Guid ID { get; set; }

        public Guid ID_Lop { get; set; }

        public Guid ID_MonHoc { get; set; }

        public int ThoiLuongHoc { get; set; }

        public DateTime NgayBatDau { get; set; }

        public DateTime NgayKetThuc { get; set; }

        public string BaoMat { get; set; }

        public string Link { get; set; }

        public int Status { get; set; }

        public string username_GiaoVien { get; set; }
    }
}
