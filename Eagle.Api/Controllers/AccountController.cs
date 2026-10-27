using Eagle.Api.ServiceInterfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Eagle.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly IAuthService _authService;

        public AccountController(IAuthService authService)
        {
            _authService = authService;
        }

        #region LogIn

        [HttpPost]
     
        public IActionResult Login(string username, string password)
        {

            if (username == "admin" && password == "password")
            {
                var accessToken = _authService.CreateAccessToken("1", username, new List<string> { "Admin" });
                return Ok(new { AccessToken = accessToken });
            }

            return Unauthorized();
        }
        #endregion
    }
}
