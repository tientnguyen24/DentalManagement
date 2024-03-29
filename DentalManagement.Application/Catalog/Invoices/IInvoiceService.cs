﻿using DentalManagement.ViewModels.Catalog.Invoices;
using DentalManagement.ViewModels.Common;
using DentalManagement.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DentalManagement.ViewModels.Catalog.Invoices.InvoiceDetails;
using DentalManagement.ViewModels.Catalog.Customers;

namespace DentalManagement.Application.Catalog.Invoices
{
    public interface IInvoiceService
    {
        Task<ApiResult<int>> Create(InvoiceCreateRequest request);
        Task<ApiResult<bool>> Update(InvoiceUpdateRequest request);
        Task<ApiResult<bool>> Delete(int invoiceId);
        Task<bool> UpdatePaymentStatus(int invoiceId, PaymentStatus updatedPaymentStatus);
        Task<List<InvoiceViewModel>> GetAll();
        Task<ApiResult<InvoiceViewModel>> GetById(int invoiceId);
        Task<ApiResult<PagedResult<InvoiceViewModel>>> GetAllPaging(GetInvoicePagingRequest request);
        Task<ApiResult<bool>> UpdateInvoiceDetailStatus(int invoiceId, int productId, Status updatedInvoiceDetailStatus, decimal prepaymentAmount);
        Task<ApiResult<InvoiceDetailViewModel>> GetInvoiceDetailById(int invoiceId, int productId);
        Task<ApiResult<bool>> UpdateInvoiceDetailDescription(int invoiceId, int productId, string description);
    }
}
