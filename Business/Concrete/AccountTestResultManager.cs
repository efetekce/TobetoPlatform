using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AccountTestResultManager : IAccountTestResultService
    {
        IAccountTestResultDal _accountTestResultDal;
        IMapper _mapper;

        public AccountTestResultManager(IAccountTestResultDal accountTestResultDal,
        IMapper mapper)
        {
            _accountTestResultDal = accountTestResultDal;
            _mapper = mapper;
        }

        public async Task<CreatedAccountTestResultResponse> Add(CreateAccountTestResultRequest createAccountTestResultRequest)
        {
            AccountTestResult accountTestResult = _mapper.Map<AccountTestResult>(createAccountTestResultRequest);
            var createdAccountTestResult = await _accountTestResultDal.AddAsync(accountTestResult);
            CreatedAccountTestResultResponse result = _mapper.Map<CreatedAccountTestResultResponse>(createdAccountTestResult);
            return result;
        }

        public async Task<DeletedAccountTestResultResponse> Delete(DeleteAccountTestResultRequest deleteAccountTestResultRequest)
        {
            AccountTestResult accountTestResult = _mapper.Map<AccountTestResult>(deleteAccountTestResultRequest);
            var deletedAccountTestResult = await _accountTestResultDal.DeleteAsync(accountTestResult);
            DeletedAccountTestResultResponse result = _mapper.Map<DeletedAccountTestResultResponse>(deletedAccountTestResult);
            return result;
        }

        public async Task<IPaginate<GetListAccountTestResultResponse>> GetListAccountTestResult(PageRequest pageRequest)
        {
            var accountTestResult = await _accountTestResultDal.GetListAsync(
                orderBy: a => a.OrderBy(a => a.AccountId),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListAccountTestResultResponse>>(accountTestResult);
            return result;
        }

        public async Task<UpdatedAccountTestResultResponse> Update(UpdateAccountTestResultRequest updateAccountTestResultRequest)
        {
            AccountTestResult accountTestResult = _mapper.Map<AccountTestResult>(updateAccountTestResultRequest);
            var updatedAccountTestResult = await _accountTestResultDal.UpdateAsync(accountTestResult);
            UpdatedAccountTestResultResponse result = _mapper.Map<UpdatedAccountTestResultResponse>(updatedAccountTestResult);
            return result;
        }
    }
}
