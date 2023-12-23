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
    public class AccountEducationManager : IAccountEducationService
    {
        IAccountEducationDal _accountEducationDal;
        IMapper _mapper;
        AccountEducationBusinessRules _accountEducationBusinessRules;

        public AccountEducationManager(IAccountEducationDal accountEducationDal,
        IMapper mapper,
        AccountEducationBusinessRules accountEducationBusinessRules)
        {
            _accountEducationDal = accountEducationDal;
            _mapper = mapper;
            _accountEducationBusinessRules = accountEducationBusinessRules;
        }

        public async Task<CreatedAccountEducationResponse> Add(CreateAccountEducationRequest createAccountEducationRequest)
        {
            await _accountEducationBusinessRules.AccountEducationNotEmpty(createAccountEducationRequest.AccountId, createAccountEducationRequest.EducationStatusId, createAccountEducationRequest.UniversityId, createAccountEducationRequest.EducationProgramId);
            AccountEducation accountEducation = _mapper.Map<AccountEducation>(createAccountEducationRequest);
            var createdAccountEducation = await _accountEducationDal.AddAsync(accountEducation);
            CreatedAccountEducationResponse result = _mapper.Map<CreatedAccountEducationResponse>(createdAccountEducation);
            return result;
        }

        public async Task<DeletedAccountEducationResponse> Delete(DeleteAccountEducationRequest deleteAccountEducationRequest)
        {
            AccountEducation accountEducation = _mapper.Map<AccountEducation>(deleteAccountEducationRequest);
            var deletedAccountEducation = await _accountEducationDal.DeleteAsync(accountEducation);
            DeletedAccountEducationResponse result = _mapper.Map<DeletedAccountEducationResponse>(deletedAccountEducation);
            return result;
        }

        public async Task<IPaginate<GetListAccountEducationResponse>> GetListAccountEducation(PageRequest pageRequest)
        {
            var accountEducation = await _accountEducationDal.GetListAsync(
                orderBy: a => a.OrderBy(a => a.UniversityId),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListAccountEducationResponse>>(accountEducation);
            return result;
        }

        public async Task<UpdatedAccountEducationResponse> Update(UpdateAccountEducationRequest updateAccountEducationRequest)
        {
            AccountEducation accountEducation = _mapper.Map<AccountEducation>(updateAccountEducationRequest);
            var updatedAccountEducation = await _accountEducationDal.UpdateAsync(accountEducation);
            UpdatedAccountEducationResponse result = _mapper.Map<UpdatedAccountEducationResponse>(updatedAccountEducation);
            return result;
        }
    }
}
