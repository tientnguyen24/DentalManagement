using DentalManagement.Application.Catalog.Users;
using DentalManagement.ViewModels.Catalog.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalManagement.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody]LoginRequest request)
        {
            var result = await _userService.Authenticate(request);
            if (string.IsNullOrEmpty(result.ResultObject))
            {
                return BadRequest(result.Message);
            }
            return Ok( new { result.Message, result.ResultObject });
        }
        
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody]RegisterRequest request)
        {
            var result = await _userService.Register(request);
            if (!result.IsSuccessed)
            {
                return BadRequest(result.Message);
            }
            return Ok(new { result.Message, result.ResultObject});
        }

        //http://localhost:port/api/users/search?keyword=?pageIndex=1?pageSize=10
        [HttpGet("search")]
        public async Task<IActionResult> GetAllPaging([FromQuery]GetUserPagingRequest request)
        {
            var users = await _userService.GetAllPaging(request);
            return Ok(users);
        }

        //http://localhost:port/api/users/{userName}
        [HttpGet("{userName}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByUserName(string userName)
        {
            var user = await _userService.GetByUserName(userName);
            if (!user.IsSuccessed) return BadRequest(user.Message);
            return Ok(user.ResultObject);
        }
    }
}
