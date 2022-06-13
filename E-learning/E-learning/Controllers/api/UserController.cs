using E_learning.Entity;
using E_learning.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserManager<AspNetUser> userManager { get; set; }
        RoleManager<IdentityRole> roleManager { get; set; }
        IConfiguration configuration { get; set; }
        public UserController(UserManager<AspNetUser>
        userManager, RoleManager<IdentityRole> roleManager, IConfiguration
        configuration)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.configuration = configuration;
        }
        [HttpPost]
        public async Task<ActionResult> Register(UserModel userModel)
        {
            if (!await roleManager.RoleExistsAsync("Teacher"))
            {
                await roleManager.CreateAsync(new IdentityRole("Teacher"));
            }
            if (!await roleManager.RoleExistsAsync("Student"))
            {
                await roleManager.CreateAsync(new IdentityRole("Student"));
            }
            AspNetUser user = new AspNetUser();
            user.UserName = userModel.UserName;
            user.HoTen = userModel.HoTen;
            user.GioiTinh = userModel.GioiTinh;
            user.Email = userModel.Email;
            user.Id = Guid.NewGuid().ToString();
            var result = await userManager.CreateAsync(user,
            userModel.MatKhau);
            // await userManager.AddToRoleAsync(user, "Teacher");
            await userManager.AddToRoleAsync(user, "Student");
            return Ok(new { status = true, message = "Register successful" });
        }

    }
}
