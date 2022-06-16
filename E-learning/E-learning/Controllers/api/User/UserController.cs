using AutoMapper;
using E_learning.AutoMapper_Config;
using E_learning.Entity;
using E_learning.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace E_learning.Controllers.api.User
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

        [HttpGet]
        public async Task<ActionResult> GetUsers()
        {
            try
            {
                var listUser = userManager.Users;
                return Ok(new { result = true, data = listUser });
            }
            catch
            {
                return Ok(new { result = false, message = "Can not GET user !" });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Register(UserModel userModel)
        {
            try
            {
                if (!await roleManager.RoleExistsAsync("Teacher"))
                {
                    await roleManager.CreateAsync(new IdentityRole("Teacher"));
                }
                if (!await roleManager.RoleExistsAsync("Student"))
                {
                    await roleManager.CreateAsync(new IdentityRole("Student"));
                }

                var config = new MapperConfiguration(cfg =>
                {
                    UserConfig.CreateMap(cfg);
                });

                var mapper = config.CreateMapper();

                AspNetUser user = new AspNetUser();
                user = mapper.Map<UserModel, AspNetUser>(userModel);
             
                user.Id = Guid.NewGuid().ToString();

                PasswordHasher<AspNetUser> hasher = new PasswordHasher<AspNetUser>();
                user.PasswordHash = hasher.HashPassword(user, userModel.MatKhau);

                var result = await userManager.CreateAsync(user);

                switch(userModel.Quyen)
                {
                    case "Teacher":
                        await userManager.AddToRoleAsync(user, "Teacher");
                        break;

                    case "Student":
                        await userManager.AddToRoleAsync(user, "Student");
                        break;

                    default:
                        await userManager.AddToRoleAsync(user, "Student");
                        break;
                }

                return Ok(new { result = true, message = "Register user successful !" });
            }
            catch
            {
                return Ok(new { result = true, message = "Register user failed !" });
            }
        }

        [HttpPut]
        public async Task<ActionResult> UpdateInfo_User (string username, ModelUser userModel)
        {
            try
            {
                var user = await userManager.FindByNameAsync(username);

                user.UserName = userModel.UserName;
                user.Email = userModel.Email;
                user.HoTen = userModel.HoTen;
                user.GioiTinh = userModel.GioiTinh;

                await userManager.RemovePasswordAsync(user);

                PasswordHasher<AspNetUser> hasher = new PasswordHasher<AspNetUser>();
                user.PasswordHash = hasher.HashPassword(user, userModel.MatKhau);

                var result = await userManager.UpdateAsync(user);
                
                return Ok(new { result = true, message = "Update user successful !" });
            }
            catch
            {
                return Ok(new { result = true, message = "Update user failed !" });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Delete_User(string username)
        {
            try
            {

                var user = await userManager.FindByNameAsync(username);
                userManager.DeleteAsync(user);
                return Ok(new { result = true, message = "Delete User successful !" });
            }
            catch
            {
                return Ok(new { result = false, message = "Delete User failed !" });
            }
        }

    }
}
