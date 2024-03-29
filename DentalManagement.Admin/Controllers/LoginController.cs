﻿using DentalManagement.ApiIntegration.ApiIntegrations;
using DentalManagement.ViewModels.Catalog.Users;
using DentalManagement.ViewModels.Common;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
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
    public class LoginController : Controller
    {
        private readonly IUserApiClient _userApiClient;
        private readonly IConfiguration _configuration;
        private readonly IValidator<LoginRequest> _loginRequestValidator;
        public LoginController(IUserApiClient userApiClient, IConfiguration configuration, IValidator<LoginRequest> loginRequestValidator)
        {
            _userApiClient = userApiClient;
            _configuration = configuration;
            _loginRequestValidator = loginRequestValidator;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginRequest request)
        {
            ValidationResult result = await _loginRequestValidator.ValidateAsync(request);
            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                return View("Index", request);
            }
            var token = await _userApiClient.Authenticate(request);
            if (token.Data == null)
            {
                result.AddToModelState(this.ModelState);
                this.ModelState.AddModelError("", token.Message);
                return View("Index", request);
            }
            var userPrincipal = this.ValidateToken(token.Data);
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddDays(2),
                IsPersistent = true
            };
            HttpContext.Session.SetString("Token", token.Data);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal, authProperties);
            return RedirectToAction("Index", "Home");
        }

        //decryption token
        private ClaimsPrincipal ValidateToken(string jwtToken)
        {
            IdentityModelEventSource.ShowPII = true;
            SecurityToken validatedToken;
            TokenValidationParameters validationParameters = new TokenValidationParameters
            {
                ValidateLifetime = true,
                ValidAudience = _configuration["Tokens:Issuer"],
                ValidIssuer = _configuration["Tokens:Issuer"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]))
            };
            ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(jwtToken, validationParameters, out validatedToken);
            return principal;
        }
    }
}
