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
            //var products = _context.Products;
            var invoiceDetails = new List<InvoiceDetail>();

            foreach (var item in request.InvoiceDetails)
            {
                //if (product.Id == request.ProductId)
                //{
                invoiceDetails.Add(new InvoiceDetail()
                {
                    ProductId = item.ProductId,
                    ItemDiscountPercent = item.ItemDiscountPercent,
                    ItemDiscountAmount = item.ItemDiscountAmount,
                    ItemAmount = item.ItemAmount,
                    Quantity = item.Quantity
                });
                //}
            }

            var invoice = new Invoice()
            {
                CreatedDate = request.CreatedDate,
                CreatedBy = request.CreatedBy,
                TotalDiscountPercent = request.TotalDiscountPercent,
                TotalDiscountAmount = request.TotalDiscountAmount,
                TotalInvoiceAmount = request.TotalInvoiceAmount,
                CustomerId = request.CustomerId,
                Description = request.Description,
                PrepaymentAmount = request.PrepaymentAmount,
                InvoiceDetails = invoiceDetails
            };
            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(invoice.Id);
        }

        public async Task<int> Delete(int id)
        {
            var invoice = await _context.Invoices.FindAsync(id);
            if (invoice == null)
            {
                throw new DentalManagementException($"Không tìm thấy hoá đơn: {id}");
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

                foreach (var item in query)
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

        public async Task<bool> UpdateStatus(int id, PaymentStatus updatedPaymentStatus)
        {
            var invoice = await _context.Invoices.FindAsync(id);
            if (invoice == null)
            {
                throw new DentalManagementException($"Không tìm thấy hoá đơn {id}");
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

        public async Task<List<InvoiceViewModel>> GetAllByCustomerId(int id)
        {
            var query = from c in _context.Customers
                        join i in _context.Invoices on c.Id equals i.CustomerId
                        select new { c, i };
            if (id > 0)
            {
                query = query.Where(x => x.c.Id == id);
                if (!query.Any())
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
                        Description = x.i.Description,
                        PaymentStatus = x.i.PaymentStatus,
                    }).ToListAsync();
                    return data;
                }
                else
                {
                    throw new DentalManagementException($"Không có hoá đơn cho khách hàng {id}");
                }

            }
            else
            {
                throw new DentalManagementException($"Khách hàng không tồn tại");
            }
        }

        public async Task<List<InvoiceDetailViewModel>> GetInvoiceDetailsByInvoiceId(int id)
        {
            var query = from inv in _context.Invoices
                        join invd in _context.InvoiceDetails on inv.Id equals invd.InvoiceId
                        select new {inv, invd};
            if (id > 0)
            {
                query = query.Where(x => x.invd.InvoiceId == id);
                var data = await query.Select(x => new InvoiceDetailViewModel()
                {
                    ProductId = x.invd.ProductId,
                    ItemDiscountPercent = x.invd.ItemDiscountPercent,
                    ItemDiscountAmount = x.invd.ItemDiscountAmount,
                    ItemAmount = x.invd.ItemAmount,
                    Quantity = x.invd.Quantity
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
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).Select(x => new InvoiceViewModel()
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

        public async Task<InvoiceViewModel> GetById(int id)
        {
            var invoice = await _context.Invoices
                .Include(i => i.InvoiceDetails)
                .ThenInclude(i=>i.Product)
                .FirstOrDefaultAsync(i => i.Id == id);
            if (invoice == null)
            {
                throw new DentalManagementException($"Không tìm thấy hoá đơn có id: {id}");
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
                    ModifiedDate = invoice.ModifiedDate,
                    ModifiedBy = invoice.ModifiedBy,
                    Description = invoice.Description,
                    PaymentStatus = invoice.PaymentStatus,
                    //check invoice details entity, if invoice details is null then do not create new instance InvoiceDetailViewModel and fill to list
                    InvoiceDetailViewModels = invoice.InvoiceDetails?.Select(invd => new InvoiceDetailViewModel()
                    {
                        InvoiceId = invd.InvoiceId,
                        ProductId = invd.ProductId,
                        ProductName = invd.Product.Name,
                        Quantity = invd.Quantity,
                        UnitPrice = invd.Product.UnitPrice,
                        ItemDiscountPercent = invd.ItemDiscountPercent,
                        ItemDiscountAmount = invd.ItemDiscountAmount,
                        ItemAmount = invd.ItemAmount
                    }).ToList()
                };
                return invoiceViewModel;
            }
        }
    }
}
