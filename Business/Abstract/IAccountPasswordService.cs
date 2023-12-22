using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAccountPasswordService
    {
        Task<CreatedAccountPasswordResponse> Add(CreateAccountPasswordRequest createAccountPasswordRequest);
        Task<IPaginate<GetListAccountPasswordResponse>> GetListAccountPassword();
        Task<UpdatedAccountPasswordResponse> Update(UpdateAccountPasswordRequest updateAccountPasswordRequest);
        Task<DeletedAccountPasswordResponse> Delete(DeleteAccountPasswordRequest deleteAccountPasswordRequest);
    }
}
