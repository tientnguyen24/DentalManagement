using DentalManagement.ViewModels.Catalog.Users;
using DentalManagement.Data.EF;
using DentalManagement.Data.Entities;
using DentalManagement.Utilities.Exceptions;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using DentalManagement.ViewModels.Common;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DentalManagement.Utilities.Constants;

namespace DentalManagement.Application.Catalog.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IConfiguration _config;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager, IConfiguration config, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _httpContextAccessor = httpContextAccessor;
            _config = config;
        }

        public async Task<ApiResult<string>> Authenticate(LoginRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user == null) return new ApiErrorResult<string>(SystemConstants.AppErrorMessage.Authenticate);

            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
            if (!result.Succeeded)
            {
                return new ApiErrorResult<string>(SystemConstants.AppErrorMessage.Authenticate);
            }
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.MobilePhone, user.PhoneNumber),
                new Claim(ClaimTypes.Role, string.Join(";",roles)),

            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(_config["Tokens:Issuer"],_config["Tokens:Issuer"],claims,expires: DateTime.Now.AddHours(48),signingCredentials: creds);
            return new ApiSuccessResult<string>(SystemConstants.AppSuccessMessage.Authenticate, new JwtSecurityTokenHandler().WriteToken(token));
        }

        public async Task<PagedResult<UserViewModel>> GetAllPaging(GetUserPagingRequest request)
        {
            var query = _userManager.Users;
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.UserName.Contains(request.Keyword) || x.PhoneNumber.Contains(request.Keyword) || x.Email.Contains(request.Keyword));
            }
            int totalRow = await query.CountAsync();
            var data = await query.OrderBy(x => x.Id).Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).Select(x => new UserViewModel()
            {
                Id = x.Id,
                UserName = x.UserName,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber,
            }).ToListAsync();
            var pagedResult = new PagedResult<UserViewModel>()
            {
                TotalRecords = totalRow,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<UserViewModel>> GetByUserName(string userName)
        {
            var result = await _userManager.FindByNameAsync(userName);
            if (result == null) return new ApiErrorResult<UserViewModel>("Không tìm thấy tài khoản");
            var data = new UserViewModel()
            {
                Id = result.Id,
                UserName = result.UserName,
                Email = result.Email,
                PhoneNumber = result.PhoneNumber
            };
            return new ApiSuccessResult<UserViewModel>(data);
        }

        public async Task<ApiResult<bool>> Register(RegisterRequest request)
        {
            var result = await _userManager.FindByNameAsync(request.UserName);
            if (result != null) return new ApiErrorResult<bool>("Tên đăng nhập đã tồn tại");

            var user = new AppUser()
            {
                UserName = request.UserName,
                Email = request.EmailAddress,
                PhoneNumber = request.PhoneNumber,
                CreatedDate = DateTime.Now,
                CreatedBy = request.EmailAddress,
            };
            var data = await _userManager.CreateAsync(user, request.ConfirmPassword);
            if (!data.Succeeded)
            {
                return new ApiErrorResult<bool>("Đăng ký không thành công");
            }
            return new ApiSuccessResult<bool>();
        }
    }
}