using DentalManagement.ViewModels.Catalog.Customers;
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
using DentalManagement.Utilities.Constants;

namespace DentalManagement.Application.Catalog.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly DentalManagementDbContext _context;
        public CustomerService(DentalManagementDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<int>> Create(CustomerCreateRequest request)
        {
            var customer = new Customer()
            {
                FullName = request.FullName,
                Gender = request.Gender,
                BirthDay = request.BirthDay,
                Address = request.Address,
                PhoneNumber = request.PhoneNumber,
                EmailAddress = request.EmailAddress,
                CreatedDate = DateTime.Now,
                IdentifyCard = request.IdentifyCard,
                Description = request.Description,
            };
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(customer.Id);
        }

        public async Task<ApiResult<bool>> Update(CustomerUpdateRequest request)
        {
            var customer = await _context.Customers.FindAsync(request.Id);
            if (customer == null)
            {
                return new ApiErrorResult<bool>(SystemConstants.AppErrorMessage.Update);
            }
            else
            {
                customer.FullName = request.FullName;
                customer.Gender = request.Gender;
                customer.BirthDay = request.BirthDay;
                customer.Address = request.Address;
                customer.PhoneNumber = request.PhoneNumber;
                customer.EmailAddress = request.EmailAddress;
                customer.IdentifyCard = request.IdentifyCard;
                customer.Description = request.Description;
                customer.ModifiedDate = DateTime.Now;
                customer.ModifiedBy = request.ModifiedBy;
            }
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<bool>(SystemConstants.AppSuccessMessage.Update);
        }
        public async Task<bool> UpdateStatus(int id, Status updatedStatus)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                throw new DentalManagementException($"Không tìm thấy khách hàng: {id}");
            }
            else if (customer.Status == updatedStatus)
            {
                throw new DentalManagementException($"Trạng thái hiện tại của khách hàng trùng với trạng thái cần cập nhật.");
            }
            else
            {
                customer.Status = updatedStatus;
            }
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<int> Delete(CustomerDeleteRequest request)
        {
            var customer = await _context.Customers.FindAsync(request.Id);
            if (customer == null)
            {
                throw new DentalManagementException($"Không tìm thấy khách hàng: {request.Id}");
            }
            else
            {
                _context.Customers.Remove(customer);
            }
            return await _context.SaveChangesAsync();
        }

        public async Task<List<CustomerViewModel>> GetAll()
        {
            //select customer record
            var query = from c in _context.Customers
                        select c;
            var data = await query.Select(x => new CustomerViewModel()
            {
                Id = x.Id,
                FullName = x.FullName,
                Gender = x.Gender,
                BirthDay = x.BirthDay,
                Address = x.Address,
                PhoneNumber = x.PhoneNumber,
                EmailAddress = x.EmailAddress,
                IdentifyCard = x.IdentifyCard,
                Status = x.Status,
                Description = x.Description,
                CreatedDate = x.CreatedDate,
                CreatedBy = x.CreatedBy,
                ModifiedDate = x.ModifiedDate,
                ModifiedBy = x.ModifiedBy
            }).ToListAsync();
            return data;
        }

        public async Task<PagedResult<CustomerViewModel>> GetAllPaging(GetCustomerPagingRequest request)
        {
            //select customer record
            var query = from c in _context.Customers
                        select c;
            //filter customer
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.FullName.Contains(request.Keyword) || x.PhoneNumber.Contains(request.Keyword));
            }

            //paging
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).Select(x => new CustomerViewModel()
            {
                Id = x.Id,
                FullName = x.FullName,
                Gender = x.Gender,
                BirthDay = x.BirthDay,
                Address = x.Address,
                PhoneNumber = x.PhoneNumber,
                EmailAddress = x.EmailAddress,
                IdentifyCard = x.IdentifyCard,
                Status = x.Status,
                Description = x.Description,
                CreatedDate = x.CreatedDate,
                CreatedBy = x.CreatedBy,
                ModifiedDate = x.ModifiedDate,
                ModifiedBy = x.ModifiedBy
            }).ToListAsync();
            //select and projection
            var pagedResult = new PagedResult<CustomerViewModel>()
            {
                TotalRecords = totalRow,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                Items = data,
            };
            return pagedResult;
        }

        public async Task<ApiResult<CustomerViewModel>> GetById(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return new ApiErrorResult<CustomerViewModel>("Không tìm thấy khách hàng");
            }
            var customerViewModel = new CustomerViewModel()
            {
                Id = customer.Id,
                FullName = customer.FullName,
                Gender = customer.Gender,
                BirthDay = customer.BirthDay,
                Address = customer.Address,
                PhoneNumber = customer.PhoneNumber,
                EmailAddress = customer.EmailAddress,
                IdentifyCard = customer.IdentifyCard,
                Status = customer.Status,
                Description = customer.Description,
                CreatedDate = customer.CreatedDate,
                CreatedBy = customer.CreatedBy,
                ModifiedDate = customer.ModifiedDate,
                ModifiedBy = customer.ModifiedBy

            };
            return new ApiSuccessResult<CustomerViewModel>(customerViewModel);
        }
    }
}
