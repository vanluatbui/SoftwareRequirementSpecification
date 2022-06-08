using Microsoft.AspNetCore.Identity;

namespace E_learning.Models
{
    public class AspNetUser : IdentityUser
    {
        // các cột thuộc tính cần bổ sung thêm vào bảng User của AspNet C# (nếu có)...

        public bool Status { get; set; } // trạng thái của tài khoản (hoạt động hay tạm ngừng?)
    }
}
