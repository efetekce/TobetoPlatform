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
    public interface IAccountTestResultService
    {
        Task<IPaginate<GetListAccountTestResultResponse>> GetListAccountTestResult(PageRequest pageRequest);
        Task<CreatedAccountTestResultResponse> Add(CreateAccountTestResultRequest createAccountTestResultRequest);
        Task<UpdatedAccountTestResultResponse> Update(UpdateAccountTestResultRequest updateAccountTestResultRequest);
        Task<DeletedAccountTestResultResponse> Delete(DeleteAccountTestResultRequest deleteAccountTestResultRequest);
    }
}
