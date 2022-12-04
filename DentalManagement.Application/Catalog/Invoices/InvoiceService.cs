using DentalManagement.ViewModels.Catalog.Invoices;
using DentalManagement.ViewModels.Common;
using DentalManagement.Data.EF;
using DentalManagement.Data.Entities;
using DentalManagement.Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DentalManagement.Data.Enums;

namespace DentalManagement.Application.Catalog.Invoices
{
    public class InvoiceService : IInvoiceService
    {
        private readonly DentalManagementDbContext _context;
        public InvoiceService(DentalManagementDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(InvoiceCreateRequest request)
        {
            var products = _context.Products;
            var invoiceDetails = new List<InvoiceDetail>();
            foreach (var product in products)
            {
                if (product.Id == request.ProductId)
                {
                    invoiceDetails.Add(new InvoiceDetail()
                    {
                        ProductId = request.ProductId,
                        ItemDiscountPercent = request.ItemDiscountPercent,
                        ItemDiscountAmount = request.ItemDiscountAmount,
                        ItemAmount = request.ItemAmount,
                        Quantity = request.Quantity
                    });
                }
            }
            var invoice = new Invoice()
            {
                CreatedDate = DateTime.Now,
                CreatedBy = request.CreatedBy,
                TotalDiscountPercent = request.TotalDiscountPercent,
                TotalDiscountAmount = request.TotalDiscountAmount,
                TotalInvoiceAmount = request.TotalInvoiceAmount,
                CustomerId = request.CustomerId,
                Description = request.Description,
                InvoiceDetails = invoiceDetails
            };
            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();
            return invoice.Id;
        }

        public async Task<int> Delete(InvoiceDeleteRequest request)
        {
            var invoice = await _context.Invoices.FindAsync(request.Id);
            if (invoice == null)
            {
                throw new DentalManagementException($"Không tìm thấy hoá đơn: {request.Id}");
            }
            else
            {
                _context.Invoices.Remove(invoice);
            }
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(InvoiceUpdateRequest request)
        {
            var invoice = await _context.Invoices.FindAsync(request.Id);
            if (invoice == null)
            {
                throw new DentalManagementException($"Không tìm thấy hoá đơn {request.Id}");
            }
            else
            {
                //get invoice detail list
                var query = from id in _context.InvoiceDetails
                            where id.InvoiceId == invoice.Id
                            select id;

                foreach(var item in query)
                {
                    item.ItemAmount = request.TotalInvoiceAmount;
                }

                invoice.TotalDiscountPercent = request.TotalDiscountPercent;
                invoice.TotalDiscountAmount = request.TotalDiscountPercent;
                invoice.TotalInvoiceAmount = request.TotalDiscountPercent;
                invoice.ModifiedDate = DateTime.Now;
                invoice.ModifiedBy = request.ModifiedBy;
                invoice.Description = request.Description;
                              
            }
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateStatus(int invoiceId, Status updatedStatus)
        {
            var invoice = await _context.Invoices.FindAsync(invoiceId);
            if (invoice == null)
            {
                throw new DentalManagementException($"Không tìm thấy hoá đơn {invoiceId}");
            }
            else if (invoice.Status == updatedStatus)
            {
                throw new DentalManagementException($"Trạng thái hiện tại của hoá đơn trùng với trạng thái cần cập nhật.");
            }
            else
            {
                invoice.Status = updatedStatus;
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
                CustomerId = x.i.CustomerId,
                Description = x.i.Description,
                Status = x.i.Status,
                ModifiedDate = x.i.ModifiedDate,
                ModifiedBy = x.i.ModifiedBy
            }).ToListAsync();
            return data;
        }

        public async Task<List<InvoiceViewModel>> GetAllByCustomerId(GetInvoiceByCustomerIdRequest request)
        {
            var query = from c in _context.Customers
                        join i in _context.Invoices on c.Id equals i.CustomerId
                        select new { c, i };
            if (request.CustomerId.HasValue && request.CustomerId.Value > 0)
            {
                query = query.Where(x => x.c.Id == request.CustomerId);
                if (query.Count() > 0)
                {
                    var data = await query.Select(x => new InvoiceViewModel()
                    {
                        Id = x.i.Id,
                        CreatedDate = x.i.CreatedDate,
                        CreatedBy = x.i.CreatedBy,
                        TotalDiscountPercent = x.i.TotalDiscountPercent,
                        TotalDiscountAmount = x.i.TotalDiscountAmount,
                        TotalInvoiceAmount = x.i.TotalInvoiceAmount,
                        ModifiedDate = x.i.ModifiedDate,
                        ModifiedBy = x.i.ModifiedBy,
                        CustomerId = x.i.CustomerId,
                        Description = x.i.Description,
                        Status = x.i.Status,
                        //InvoiceDetails = GetDetailByInvoiceId(x.i.Id)
                    }).ToListAsync();
                    return data;
                }
                else
                {
                    throw new DentalManagementException($"Không có hoá đơn cho khách hàng {request.CustomerId}");
                }

            }
            else
            {
                throw new DentalManagementException($"Khách hàng không tồn tại");
            }
        }

        public async Task<List<InvoiceDetailViewModel>> GetDetailByInvoiceId(int? invoiceId)
        {
            var query = from id in _context.InvoiceDetails
                        select id;
            if (invoiceId.HasValue && invoiceId.Value > 0)
            {
                query = query.Where(x => x.InvoiceId == invoiceId);
                var data = await query.Select(x => new InvoiceDetailViewModel()
                {
                    InvoiceId = x.InvoiceId,
                    ProductId = x.ProductId,
                    ItemDiscountPercent = x.ItemDiscountPercent,
                    ItemDiscountAmount = x.ItemDiscountAmount,
                    ItemAmount = x.ItemAmount,
                    Quantity = x.Quantity
                }).ToListAsync();
                return data;
            }
            else
            {
                throw new DentalManagementException($"Không hợp lệ");
            }
        }

        public async Task<ApiResult<PagedResult<InvoiceViewModel>>> GetAllPaging(GetInvoicePagingRequest request)
        {
            //select invoice record
            var query = from i in _context.Invoices
                        select new { i };
            //filter invoice
            if (request.InvoiceDate != null)
            {
                query = query.Where(x => x.i.CreatedDate.Value.Date == request.InvoiceDate);
            }

            //paging
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).Select(x => new InvoiceViewModel()
            {
                CustomerId = x.i.CustomerId,
                Id = x.i.Id,
                CreatedDate = x.i.CreatedDate,
                CreatedBy = x.i.CreatedBy,
                TotalDiscountPercent = x.i.TotalDiscountPercent,
                TotalDiscountAmount = x.i.TotalDiscountAmount,
                TotalInvoiceAmount = x.i.TotalInvoiceAmount,
                Description = x.i.Description,
                Status = x.i.Status,
                ModifiedDate = x.i.ModifiedDate,
                ModifiedBy = x.i.ModifiedBy,
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

        public async Task<InvoiceViewModel> GetById(int invoiceId)
        {
            var invoice = await _context.Invoices.FindAsync(invoiceId);
            if (invoice == null)
            {
                throw new DentalManagementException($"Không tìm thấy hoá đơn có id: {invoiceId}");
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
                    ModifiedDate = invoice.ModifiedDate,
                    ModifiedBy = invoice.ModifiedBy,
                    CustomerId = invoice.CustomerId,
                    Description = invoice.Description,
                    Status = invoice.Status,
                    InvoiceDetails = GetDetailByInvoiceId(invoice.Id)
                };
                return invoiceViewModel;
            }
        }

    }
}
