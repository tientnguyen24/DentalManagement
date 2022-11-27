﻿using DentalManagement.ViewModels.Catalog.Customers;
using DentalManagement.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DentalManagement.Admin.ApiIntegrations
{
    public class CustomerApiClient : ICustomerApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CustomerApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<bool> Create(CustomerCreateRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var response = await client.PostAsync($"/api/customers/", httpContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<PagedResult<CustomerViewModel>> GetAllPaging(GetCustomerPagingRequest request)
        {
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var response = await client.GetAsync($"/api/customers/search?keyword={request.Keyword}&pageIndex={request.PageIndex}&pageSize={request.PageSize}");
            var body = await response.Content.ReadAsStringAsync();
            var customers = JsonConvert.DeserializeObject<PagedResult<CustomerViewModel>>(body);
            return customers;
        }

    }
}
