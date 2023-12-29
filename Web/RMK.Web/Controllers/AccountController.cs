using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AMR.Web.Models;
using AMR.Web.Utility;
using RMK.Application.DTOs;
using RMK.Application.Interfaces;

namespace AMR.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[AllowAnonymous]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginFieldRequest model)
        {
            if (model.UserName == "" || model.Password == "")
                return null;
            if (model.UserName != "" && model.Password != null)
            {
                LoginUserDTO login = new LoginUserDTO();
                login.UserName = model.UserName;
                login.Password = model.Password;

                var user = await _userService.LoginUser(login);
                if(user == false) return NotFound("Username or Password Is Not Correct");

                if (user == true)
                {
                    var jwtAuthorizationManager = new JWTAuthorizationManager();
                    var result = jwtAuthorizationManager.Authenticate(model.UserName, model.Password);
                    if (result == null)
                        return Unauthorized();
                    else
                        return Ok(result);
                }
            }
            return Ok();
        }
    }
}