using DentalManagement.ViewModels.Catalog.Users;
using DentalManagement.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DentalManagement.Application.Catalog.Users
{
    public interface IUserService
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);
        Task<ApiResult<bool>> Register(RegisterRequest request);
        Task<PagedResult<UserViewModel>> GetAllPaging(GetUserPagingRequest request);
        Task<ApiResult<UserViewModel>> GetByUserName(string userName);
    }
}
