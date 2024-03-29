﻿using DentalManagement.Data.Enums;
using DentalManagement.Utilities.Constants;
using DentalManagement.ViewModels.Catalog.Customers;
using DentalManagement.ViewModels.Catalog.Invoices;
using DentalManagement.ViewModels.Catalog.Invoices.InvoiceDetails;
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

namespace DentalManagement.ApiIntegration.ApiIntegrations
{
    public class InvoiceApiClient : BaseApiClient, IInvoiceApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public InvoiceApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration, IHttpContextAccessor httpContextAccessor) : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<bool>> Create(InvoiceCreateRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var sessions = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.AppSettings.Token);
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var response = await client.PostAsync($"/api/invoices/", httpContent);
            if (!response.IsSuccessStatusCode)
            {
                return new ApiErrorResult<bool>(SystemConstants.AppErrorMessage.Create);
            }
            else
            {
				return new ApiSuccessResult<bool>(SystemConstants.AppSuccessMessage.Create);
			}
        }

        public async Task<ApiResult<bool>> Update(InvoiceUpdateRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var sessions = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.AppSettings.Token);
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var response = await client.PutAsync($"/api/invoices/", httpContent);
            return new ApiSuccessResult<bool>(SystemConstants.AppSuccessMessage.Update,response.IsSuccessStatusCode);
        }

        public async Task<ApiResult<PagedResult<InvoiceViewModel>>> GetAllPaging(GetInvoicePagingRequest request)
        {
            var sessions = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.AppSettings.Token);
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var response = await client.GetAsync($"/api/invoices/search?keyword={request.Keyword}&pageIndex={request.PageIndex}&pageSize={request.PageSize}");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiSuccessResult<PagedResult<InvoiceViewModel>>>(data);
            }
            return new ApiErrorResult<PagedResult<InvoiceViewModel>>(SystemConstants.AppErrorMessage
                .NotFound);
        }

        public async Task<ApiResult<InvoiceViewModel>> GetbyId(int invoiceId)
        {
            var sessions = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.AppSettings.Token);
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var response = await client.GetAsync($"/api/invoices/{invoiceId}");
            var data = await response.Content.ReadAsStringAsync();
            var invoice = JsonConvert.DeserializeObject<ApiSuccessResult<InvoiceViewModel>>(data);
            return invoice;
        }

        public async Task<ApiResult<bool>> UpdateInvoiceDetailStatus(int invoiceId, int productId, Status updatedInvoiceDetailStatus, decimal prepaymentAmount)
        {
            var json = JsonConvert.SerializeObject(new { invoiceId, productId, updatedInvoiceDetailStatus, prepaymentAmount });
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var sessions = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.AppSettings.Token);
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var response = await client.PatchAsync($"/api/invoices/{invoiceId}/{productId}/{updatedInvoiceDetailStatus}/{prepaymentAmount}", httpContent);
            if (!response.IsSuccessStatusCode)
            {
                return new ApiErrorResult<bool>(SystemConstants.AppErrorMessage.Update);
            }
            return new ApiSuccessResult<bool>(SystemConstants.AppSuccessMessage.Update);
        }

        public async Task<ApiResult<InvoiceDetailViewModel>> GetInvoiceDetailById(int invoiceId, int productId)
        {
            var sessions = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.AppSettings.Token);
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var response = await client.GetAsync($"/api/invoices/{invoiceId}/{productId}");
            var data = await response.Content.ReadAsStringAsync();
            var invoice = JsonConvert.DeserializeObject<ApiSuccessResult<InvoiceDetailViewModel>>(data);
            return invoice;
        }

        public async Task<ApiResult<bool>> UpdateInvoiceDetailDescription(int invoiceId, int productId, string description)
        {
            var json = JsonConvert.SerializeObject(new { invoiceId, productId, description });
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var sessions = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.AppSettings.Token);
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var response = await client.PatchAsync($"/api/invoices/{invoiceId}/{productId}/{description}", httpContent);
            if (!response.IsSuccessStatusCode)
            {
                return new ApiErrorResult<bool>(SystemConstants.AppErrorMessage.Update);
            }
            return new ApiSuccessResult<bool>(SystemConstants.AppSuccessMessage.Update);
        }

		public async Task<ApiResult<bool>> Delete(int invoiceId)
		{
			var sessions = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.AppSettings.Token);
			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
			var response = await client.DeleteAsync($"/api/invoices/{invoiceId}");
            if (!response.IsSuccessStatusCode)
            {
                return new ApiErrorResult<bool>(SystemConstants.AppErrorMessage.Delete);
            }
            else
            {
				return new ApiSuccessResult<bool>(SystemConstants.AppSuccessMessage.Delete);
			}
		}
	}
}
