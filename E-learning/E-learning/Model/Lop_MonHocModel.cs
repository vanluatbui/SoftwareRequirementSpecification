using E_learning.Entity;

namespace E_learning.Model
{
    public class Lop_MonHocModel
    {
        public Guid ID { get; set; }

        public Lop Lop { get; set; }

        public MonHoc MonHoc { get; set; }

        public int ThoiLuongHoc { get; set; }

        public DateTime NgayBatDau { get; set; }

        public DateTime NgayKetThuc { get; set; }

        public string BaoMat { get; set; }

        public string Link { get; set; }

        public int Status { get; set; }

        public AspNetUser GiaoVien { get; set; }
    }
}
