using E_learning.Entity;
using E_learning.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace E_learning.Controllers.api.User
{
    [Route("api/User/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        UserManager<AspNetUser> userManager { get; set; }
        RoleManager<IdentityRole> roleManager { get; set; }
        IConfiguration configuration { get; set; }
        public TokenController(UserManager<AspNetUser>
        userManager, RoleManager<IdentityRole> roleManager, IConfiguration
        configuration)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.configuration = configuration;
        }

        [HttpPost]
        public async Task<ActionResult> GetToken(UserModel userModel)
        {
            try
            {
                var user = await
                userManager.FindByNameAsync(userModel.UserName);
                if (user == null)
                {
                    return Ok(new { status = false, message = "Can not find user" });
                }
                var result = await userManager.CheckPasswordAsync(user,
                userModel.MatKhau);
                if (result)
                {
                    string securityKey = configuration["JWT:Secret"];
                    var symmetricSecurityKey = new
                    SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
                    var userRoles = await userManager.GetRolesAsync(user);
                    var authClaims = new List<Claim>
{
new Claim(ClaimTypes.Name, userModel.UserName),
new Claim(JwtRegisteredClaimNames.Jti,
Guid.NewGuid().ToString()),
};
                    foreach (var userRole in userRoles)
                    {
                        authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                    }
                    var signingCredentials = new
                    SigningCredentials(symmetricSecurityKey,
                    SecurityAlgorithms.HmacSha256Signature);
                    var token = new JwtSecurityToken(
                    claims: authClaims,
                    issuer: configuration["JWT:ValidIssuer"],
                    audience: configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(1),
                    signingCredentials: signingCredentials
                    );
                    string strToken = new
                    JwtSecurityTokenHandler().WriteToken(token);
                    return Ok(new { status = true, message = "", token = strToken });
                }
                return Ok(new { status = false, message = "Can not authenticate" });
            }
            catch (Exception ex)
            {
                return Ok(new { status = false, message = ex.Message });
            }
        }
    }
}
