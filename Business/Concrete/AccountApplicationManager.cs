using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concrete
{
    public class AccountApplicationManager : IAccountApplicationService
    {
        IAccountApplicationDal _accountApplicationDal;
        IMapper _mapper;
        AccountApplicationBusinessRules _accountApplicationBusinessRules;

        public AccountApplicationManager(IAccountApplicationDal accountApplicationDal,
        IMapper mapper,
        AccountApplicationBusinessRules accountApplicationBusinessRules)
        {
            _accountApplicationDal = accountApplicationDal;
            _mapper = mapper;
            _accountApplicationBusinessRules = accountApplicationBusinessRules;
        }

        public async Task<CreatedAccountApplicationResponse> Add(CreateAccountApplicationRequest createAccountApplicationRequest)
        {
            await _accountApplicationBusinessRules.AccountApplicationNotEmpty(createAccountApplicationRequest.AccountId,createAccountApplicationRequest.ApplicationId,createAccountApplicationRequest.ApplicationStepId);
            AccountApplication accountApplication = _mapper.Map<AccountApplication>(createAccountApplicationRequest);
            var createdAccountApplication = await _accountApplicationDal.AddAsync(accountApplication);
            CreatedAccountApplicationResponse result = _mapper.Map<CreatedAccountApplicationResponse>(createdAccountApplication);
            return result;
        }

        public async Task<DeletedAccountApplicationResponse> Delete(DeleteAccountApplicationRequest deleteAccountApplicationRequest)
        {
            AccountApplication accountApplication = _mapper.Map<AccountApplication>(deleteAccountApplicationRequest);
            var deletedAccountApplication = await _accountApplicationDal.DeleteAsync(accountApplication);
            DeletedAccountApplicationResponse result = _mapper.Map<DeletedAccountApplicationResponse>(deletedAccountApplication);
            return result;
        }

        public async Task<IPaginate<GetListAccountApplicationResponse>> GetListAccountApplication(PageRequest pageRequest)
        {
            var application = await _accountApplicationDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListAccountApplicationResponse>>(application);
            return result;
        }

        public async Task<UpdatedAccountApplicationResponse> Update(UpdateAccountApplicationRequest updateAccountApplicationRequest)
        {
            AccountApplication accountApplication = _mapper.Map<AccountApplication>(updateAccountApplicationRequest);
            var updatedAccountApplication = await _accountApplicationDal.UpdateAsync(accountApplication);
            UpdatedAccountApplicationResponse result = _mapper.Map<UpdatedAccountApplicationResponse>(updatedAccountApplication);
            return result;
        }
    }
}
