using DentalManagement.Admin.ApiIntegrations;
using DentalManagement.ViewModels.Catalog.Users;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DentalManagement.Admin.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserApiClient _userApiClient;
        private readonly IConfiguration _config;
        public UsersController(IUserApiClient userApiClient, IConfiguration config)
        {
            _userApiClient = userApiClient;
            _config = config;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            if (!ModelState.IsValid) return View(ModelState);
            var token = await _userApiClient.Authenticate(request);
            var userPrincipal = this.ValidateToken(token);
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                IsPersistent = true
            };
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,userPrincipal,authProperties);
            return RedirectToAction("Index", "Home");
        }

        //decryption token
        private ClaimsPrincipal ValidateToken(string jwtToken)
        {
            IdentityModelEventSource.ShowPII = true;
            TokenValidationParameters validationParameters = new TokenValidationParameters
            {
                ValidateLifetime = true,
                ValidAudience = _config["Tokens:Issuer"],
                ValidIssuer = _config["Tokens:Issuer"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]))
            };
            ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(jwtToken, validationParameters, validatedToken: out _);
            return principal;
        }
    }
}
