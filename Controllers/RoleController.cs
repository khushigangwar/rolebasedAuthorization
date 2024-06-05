using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using rolebasedAuthorization.Models;

namespace rolebasedAuthorization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityUser> _rolemanager;
        private readonly IConfiguration _configuration;
        public RoleController(UserManager<IdentityUser> userManager,RoleManager<IdentityUser>roleManager,IConfiguration configuration)
        {
            _userManager = userManager;
            _rolemanager = roleManager;
            _configuration = configuration;
                
        }
        [HttpGet("register")]
        public async Task<IActionResult> Register([FromBody] Register model)
        {
            var user = new IdentityUser { UserName = model.Username };
            var result=await _userManager.CreateAsync(user,model.Password);
            if(result.Succeeded)
            {
                return Ok(new { message = "User Registered Successfully" });
            }
            return BadRequest(result.Errors);
        }
    }
}
