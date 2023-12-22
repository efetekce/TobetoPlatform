using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;

namespace Business.Abstract
{
    public interface IAccountApplicationService
    {
        Task<IPaginate<GetListAccountApplicationResponse>> GetListAccountApplication();
        Task<CreatedAccountApplicationResponse> Add(CreateAccountApplicationRequest createAccountApplicationRequest);
        Task<UpdatedAccountApplicationResponse> Update(UpdateAccountApplicationRequest updateAccountApplicationRequest);
        Task<DeletedAccountApplicationResponse> Delete(DeleteAccountApplicationRequest deleteAccountApplicationRequest);
    }
}
