//api-controller
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.EntityFrameworkCore;
using web_api_base.Helper;
using web_api_base.Models.dbebay;
//using webapi_blazor.Models;

namespace web_api_base.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("/user/login")]
        public async Task<ActionResult> Login(UserLoginVM userLogin)
        {
            return await _userService.Login(userLogin);
        }
        [Authorize]
        [HttpGet("/user/GetProfile")]
        public async Task<ActionResult> GetProfile([FromHeader] string authorization)
        {
            // string token = authorization.Replace("Bearer ", "");
            // // string token  = HttpContext.Request.Headers["Authorization"];
            // string account = _jwtService.DecodePayloadToken(token);
            // var user = _context.Users.SingleOrDefault(us => us.Username == account || us.Email == account);
            // return Ok(user);
            return Ok("");
        }

        [Authorize(Roles = "Buyer,Seller")]
        [HttpGet("/user/PostNew")]
        public async Task<ActionResult> PostNew()
        {

            return Ok("");
        }

    }
}



