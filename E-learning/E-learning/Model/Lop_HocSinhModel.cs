using E_learning.Entity;

namespace E_learning.Model
{
    public class Lop_HocSinhModel
    {
        public Lop Lop { get; set; }

        public AspNetUser HocSinh { get; set; }
        public DateTime NgayThamGia { get; set; }
    }
}
