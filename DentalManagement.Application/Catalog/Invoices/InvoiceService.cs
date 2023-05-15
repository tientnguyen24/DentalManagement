using DentalManagement.ViewModels.Catalog.Invoices;
using DentalManagement.ViewModels.Catalog.Invoices.InvoiceDetails;
using DentalManagement.ViewModels.Common;
using DentalManagement.Data.EF;
using DentalManagement.Data.Entities;
using DentalManagement.Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DentalManagement.Data.Enums;
using DentalManagement.ViewModels.Catalog.Customers;
using DentalManagement.Utilities.Constants;

namespace DentalManagement.Application.Catalog.Invoices
{
    public class InvoiceService : IInvoiceService
    {
        private readonly DentalManagementDbContext _context;
        public InvoiceService(DentalManagementDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<int>> Create(InvoiceCreateRequest request)
        {
            var invoiceDetails = new List<InvoiceDetail>();
            foreach (var item in request.InvoiceDetails)
            {
                invoiceDetails.Add(new InvoiceDetail()
                {
                    ProductId = item.ProductId,
                    ItemDiscountPercent = item.ItemDiscountPercent,
                    ItemDiscountAmount = item.ItemDiscountAmount,
                    ItemAmount = item.ItemAmount,
                    Quantity = item.Quantity,
                    CompletedDate = item.CompletedDate,
                    Status = item.Status
                });
            }

            var invoice = new Invoice()
            {
                CreatedDate = request.CreatedDate,
                CreatedBy = request.CreatedBy,
                TotalDiscountPercent = request.TotalDiscountPercent,
                TotalDiscountAmount = request.TotalDiscountAmount,
                TotalInvoiceAmount = request.TotalInvoiceAmount,
                Description = request.Description,
                CustomerId = request.CustomerId,
                PaymentStatus = request.PaymentStatus,
                PrepaymentAmount = request.PrepaymentAmount,
                RemainAmount = request.RemainAmount,
                InvoiceDetails = invoiceDetails
            };
            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(invoice.Id);
        }

        public async Task<int> Delete(int invoiceId)
        {
            var invoice = await _context.Invoices.FindAsync(invoiceId);
            if (invoice == null)
            {
                throw new DentalManagementException($"Không tìm thấy hoá đơn: {invoiceId}");
            }
            else
            {
                _context.Invoices.Remove(invoice);
            }
            return await _context.SaveChangesAsync();
        }

        public async Task<ApiResult<bool>> Update(InvoiceUpdateRequest request)
        {
            var invoice = await _context.Invoices
                .Include(i => i.InvoiceDetails)
                .FirstOrDefaultAsync(i => i.Id == request.Id);
            if (invoice == null)
            {
                return new ApiErrorResult<bool>(SystemConstants.AppErrorMessage.Update);
            }
            else
            {
                if (request.InvoiceDetails != null)
                {
                    var invoiceDetails = new List<InvoiceDetail>();
                    foreach (var existingItem in invoice.InvoiceDetails)
                    {
                        var updateItem = request.InvoiceDetails.FirstOrDefault(x => x.ProductId == existingItem.ProductId);
                        if (updateItem == null)
                        {
                            // item not found in request, update its properties
                            existingItem.ItemAmount = 0;
                            existingItem.Status = Status.Cancelled;
                            existingItem.CompletedDate = null;
                            invoiceDetails.Add(existingItem);
                        }
                        else
                        {
                            // item found in request, update its properties
                            existingItem.ItemDiscountPercent = updateItem.ItemDiscountPercent;
                            existingItem.ItemDiscountAmount = updateItem.ItemDiscountAmount;
                            existingItem.ItemAmount = updateItem.ItemAmount;
                            existingItem.Quantity = updateItem.Quantity;
                            existingItem.CompletedDate = updateItem.CompletedDate;
                            existingItem.Status = updateItem.Status;
                            invoiceDetails.Add(existingItem);
                        }
                    }

                    // add any new items in request that don't exist in invoice.InvoiceDetails
                    var newItems = request.InvoiceDetails.Where(x => !invoice.InvoiceDetails.Any(y => y.ProductId == x.ProductId));
                    foreach (var item in newItems)
                    {
                        invoiceDetails.Add(new InvoiceDetail()
                        {
                            InvoiceId = item.InvoiceId,
                            ProductId = item.ProductId,
                            ItemDiscountPercent = item.ItemDiscountPercent,
                            ItemDiscountAmount = item.ItemDiscountAmount,
                            ItemAmount = item.ItemAmount,
                            Quantity = item.Quantity,
                            CompletedDate = item.CompletedDate,
                            Status = item.Status
                        });
                    }

                    // set the updated list of invoice details
                    invoice.InvoiceDetails = invoiceDetails;
                }
                invoice.TotalDiscountPercent = request.TotalDiscountPercent;
                invoice.TotalDiscountAmount = request.TotalDiscountAmount;
                invoice.TotalInvoiceAmount = request.TotalInvoiceAmount;
                invoice.ModifiedDate = request.ModifiedDate;
                invoice.ModifiedBy = request.ModifiedBy;
                invoice.Description = request.Description;
                invoice.PaymentStatus = request.PaymentStatus;
                invoice.PrepaymentAmount = request.PrepaymentAmount;
                invoice.RemainAmount = request.RemainAmount;
            }
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<bool>(SystemConstants.AppSuccessMessage.Update);
        }

        public async Task<bool> UpdatePaymentStatus(int invoiceId, PaymentStatus updatedPaymentStatus)
        {
            var invoice = await _context.Invoices.FindAsync(invoiceId);
            if (invoice == null)
            {
                throw new DentalManagementException($"Không tìm thấy hoá đơn {invoiceId}");
            }
            else if (invoice.PaymentStatus == updatedPaymentStatus)
            {
                throw new DentalManagementException($"Trạng thái hiện tại của hoá đơn trùng với trạng thái cần cập nhật.");
            }
            else
            {
                invoice.PaymentStatus = updatedPaymentStatus;
            }
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<List<InvoiceViewModel>> GetAll()
        {
            var query = from i in _context.Invoices
                        select new { i };
            var data = await query.Select(x => new InvoiceViewModel()
            {
                Id = x.i.Id,
                CreatedDate = x.i.CreatedDate,
                CreatedBy = x.i.CreatedBy,
                TotalDiscountPercent = x.i.TotalDiscountPercent,
                TotalDiscountAmount = x.i.TotalDiscountAmount,
                TotalInvoiceAmount = x.i.TotalInvoiceAmount,
                Description = x.i.Description,
                PaymentStatus = x.i.PaymentStatus,
                ModifiedDate = x.i.ModifiedDate,
                ModifiedBy = x.i.ModifiedBy
            }).ToListAsync();
            return data;
        }
        public async Task<ApiResult<PagedResult<InvoiceViewModel>>> GetAllPaging(GetInvoicePagingRequest request)
        {
            //select invoice record
            var query = from i in _context.Invoices
                        join c in _context.Customers on i.CustomerId equals c.Id
                        select new { i, c };
            //filter invoice
            if (request.Keyword != null)
            {
                DateTime invoiceDate = DateTime.Parse(request.Keyword);
                query = query.Where(x => x.i.CreatedDate.Value.Date == invoiceDate);
            }

            //paging
            int totalRow = await query.CountAsync();
            var data = await query.OrderBy(x => x.i.Id).Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).Select(x => new InvoiceViewModel()
            {
                Id = x.i.Id,
                CreatedDate = x.i.CreatedDate,
                CreatedBy = x.i.CreatedBy,
                TotalDiscountPercent = x.i.TotalDiscountPercent,
                TotalDiscountAmount = x.i.TotalDiscountAmount,
                TotalInvoiceAmount = x.i.TotalInvoiceAmount,
                Description = x.i.Description,
                PaymentStatus = x.i.PaymentStatus,
                ModifiedDate = x.i.ModifiedDate,
                ModifiedBy = x.i.ModifiedBy,
                PrepaymentAmount = x.i.PrepaymentAmount,
            }).ToListAsync();
            //select and projection
            var pagedResult = new PagedResult<InvoiceViewModel>()
            {
                TotalRecords = totalRow,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                Items = data
            };
            return new ApiSuccessResult<PagedResult<InvoiceViewModel>>(pagedResult);
        }

        public async Task<ApiResult<InvoiceViewModel>> GetById(int invoiceId)
        {
            var invoice = await _context.Invoices
                .Include(x => x.InvoiceDetails)
                .ThenInclude(x => x.Product)
                .AsSplitQuery()
                .FirstOrDefaultAsync(x => x.Id == invoiceId);
            if (invoice == null)
            {
                return new ApiErrorResult<InvoiceViewModel>(SystemConstants.AppErrorMessage.NotFound);
            }
            else
            {
                var invoiceViewModel = new InvoiceViewModel()
                {
                    Id = invoice.Id,
                    CreatedDate = invoice.CreatedDate,
                    CreatedBy = invoice.CreatedBy,
                    TotalDiscountPercent = invoice.TotalDiscountPercent,
                    TotalDiscountAmount = invoice.TotalDiscountAmount,
                    TotalInvoiceAmount = invoice.TotalInvoiceAmount,
                    PrepaymentAmount = invoice.PrepaymentAmount,
                    RemainAmount = invoice.RemainAmount,
                    ModifiedDate = invoice.ModifiedDate,
                    ModifiedBy = invoice.ModifiedBy,
                    Description = invoice.Description,
                    PaymentStatus = invoice.PaymentStatus,
                    CustomerId = invoice.CustomerId,
                    //check invoice details entity, if invoice details is null then do not create new instance InvoiceDetailViewModel and fill to list
                    InvoiceDetailViewModels = invoice.InvoiceDetails?.Select(invoiceDetail => new InvoiceDetailViewModel()
                    {
                        InvoiceId = invoiceDetail.InvoiceId,
                        ProductId = invoiceDetail.ProductId,
                        ProductName = invoiceDetail.Product.Name,
                        UnitPrice = invoiceDetail.Product.UnitPrice,
                        ItemDiscountPercent = invoiceDetail.ItemDiscountPercent,
                        ItemDiscountAmount = invoiceDetail.ItemDiscountAmount,
                        ItemAmount = invoiceDetail.ItemAmount,
                        Quantity = invoiceDetail.Quantity,
                        Status = invoiceDetail.Status,
                        CompletedDate = invoiceDetail.CompletedDate
                    }).ToList()
                };
                return new ApiSuccessResult<InvoiceViewModel>(invoiceViewModel);
            }
        }

        public async Task<ApiResult<bool>> UpdateInvoiceDetailStatus(int invoiceId, int productId, Status updatedInvoiceDetailStatus, decimal prepaymentAmount)
        {
            var invoice = await _context.Invoices
                    .Include(x => x.InvoiceDetails)
                    .AsSplitQuery()
                    .FirstOrDefaultAsync(x => x.Id == invoiceId);
            var invoiceDetail = invoice.InvoiceDetails.SingleOrDefault(i => i.ProductId == productId);
            if (invoiceDetail == null || invoiceDetail.Status == updatedInvoiceDetailStatus)
            {
                return new ApiErrorResult<bool>(SystemConstants.AppErrorMessage.Update);
            }
            else
            {
                var request = new InvoiceUpdateRequest()
                {
                    Id = invoiceId,
                    TotalDiscountPercent = invoice.TotalDiscountPercent,
                    TotalDiscountAmount = invoice.TotalDiscountAmount,
                    TotalInvoiceAmount = invoice.TotalInvoiceAmount,
                    ModifiedDate = DateTime.Now,
                    ModifiedBy = invoice.ModifiedBy,
                    Description = invoice.Description,
                    PaymentStatus = invoice.PaymentStatus,
                    PrepaymentAmount = invoice.PrepaymentAmount,
                    RemainAmount = invoice.RemainAmount,
                };
                switch (updatedInvoiceDetailStatus)
                {
                    //cancel but remain still has value
                    case Status.Cancelled:
                        request.TotalInvoiceAmount = invoice.TotalInvoiceAmount - invoiceDetail.ItemAmount;
                        request.PrepaymentAmount += prepaymentAmount;
                        request.RemainAmount = request.TotalInvoiceAmount - request.PrepaymentAmount;
                        _ = await Update(request);
                        invoiceDetail.Status = updatedInvoiceDetailStatus;
                        invoiceDetail.CompletedDate = null;
                        invoiceDetail.ItemAmount = 0;
                        break;

                    case Status.Completed:
                        //update total invoice if prepayment changes
                        if (prepaymentAmount > 0)
                        {
                            request.PrepaymentAmount += prepaymentAmount;
                            request.RemainAmount = request.TotalInvoiceAmount - request.PrepaymentAmount;
                            _ = await Update(request);
                        }
                        invoiceDetail.Status = updatedInvoiceDetailStatus;
                        invoiceDetail.CompletedDate = DateTime.Now;
                        break;

                    default:
                        return new ApiErrorResult<bool>(SystemConstants.AppErrorMessage.Update);
                }
            }
            //if there is no processing status in invoice detail then completing invoice
            if (!invoice.InvoiceDetails.Any(inv => inv.Status == Status.Processing))
            {
                _ = await UpdatePaymentStatus(invoiceId, PaymentStatus.Completed);
            }
            //update status payment when all invoice in detail is cancel
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<bool>(SystemConstants.AppSuccessMessage.Update);
        }

        public async Task<ApiResult<InvoiceDetailViewModel>> GetInvoiceDetailById(int invoiceId, int productId)
        {
            var invoice = await _context.Invoices
                .Include(x => x.InvoiceDetails)
                .ThenInclude(x => x.Product)
                .AsSplitQuery()
                .FirstOrDefaultAsync(x => x.Id == invoiceId);
            if (invoice == null)
            {
                return new ApiErrorResult<InvoiceDetailViewModel>(SystemConstants.AppErrorMessage.NotFound);
            }
            else
            {
                var invoiceDetail = invoice.InvoiceDetails?.FirstOrDefault(x => x.ProductId == productId);
                if (invoiceDetail == null)
                {
                    return new ApiErrorResult<InvoiceDetailViewModel>(SystemConstants.AppErrorMessage.NotFound);
                }
                else
                {
                    var invoiceDetailViewModel = new InvoiceDetailViewModel
                    {
                        InvoiceId = invoiceDetail.InvoiceId,
                        ProductId = invoiceDetail.ProductId,
                        ProductName = invoiceDetail.Product.Name,
                        UnitPrice = invoiceDetail.Product.UnitPrice,
                        ItemDiscountPercent = invoiceDetail.ItemDiscountPercent,
                        ItemDiscountAmount = invoiceDetail.ItemDiscountAmount,
                        ItemAmount = invoiceDetail.ItemAmount,
                        Quantity = invoiceDetail.Quantity,
                        Status = invoiceDetail.Status,
                        CompletedDate = invoiceDetail.CompletedDate
                    };
                    return new ApiSuccessResult<InvoiceDetailViewModel>(invoiceDetailViewModel);
                }
            }
        }
    }
}
