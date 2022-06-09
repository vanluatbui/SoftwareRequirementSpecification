using Microsoft.AspNetCore.Identity;

namespace E_learning.Entity
{
    public class AspNetUser : IdentityUser
    {
        // các cột thuộc tính cần bổ sung thêm vào bảng User của AspNet C# (nếu có)...

        public string HoTen { get; set; }
        public bool GioiTinh { get; set; } // false : girl - true : boy
    }
}
