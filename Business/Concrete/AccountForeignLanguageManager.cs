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
    public class AccountForeignLanguageManager : IAccountForeignLanguageService
    {
        IAccountForeignLanguageDal _accountForeignLanguageDal;
        IMapper _mapper;
        public AccountForeignLanguageManager(IAccountForeignLanguageDal accountForeignLanguageDal, IMapper mapper)
        {
            _accountForeignLanguageDal = accountForeignLanguageDal;
            _mapper = mapper;
        }
        public async Task<CreatedAccountForeignLanguageResponse> Add(CreateAccountForeignLanguageRequest createAccountForeignLanguageRequest)
        {
            AccountForeignLanguage accountForeignLanguage = _mapper.Map<AccountForeignLanguage>(createAccountForeignLanguageRequest);
            var createdAccountForeignLanguage = await _accountForeignLanguageDal.AddAsync(accountForeignLanguage);
            CreatedAccountForeignLanguageResponse result = _mapper.Map<CreatedAccountForeignLanguageResponse>(createdAccountForeignLanguage);
            return result;
        }

        public async Task<DeletedAccountForeignLanguageResponse> Delete(DeleteAccountForeignLanguageRequest deleteAccountForeignLanguageRequest)
        {
            AccountForeignLanguage accountForeignLanguage = _mapper.Map<AccountForeignLanguage>(deleteAccountForeignLanguageRequest);
            var deletedAccountForeignLanguage = await _accountForeignLanguageDal.DeleteAsync(accountForeignLanguage, false);
            DeletedAccountForeignLanguageResponse result = _mapper.Map<DeletedAccountForeignLanguageResponse>(deletedAccountForeignLanguage);
            return result;
        }

        public async Task<IPaginate<GetListAccountForeignLanguageResponse>> GetListAccount(PageRequest pageRequest)
        {
            var accountForeignLanguage = await _accountForeignLanguageDal.GetListAsync(
                orderBy: a => a.OrderBy(a => a.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListAccountForeignLanguageResponse>>(accountForeignLanguage);
            return result;
        }

        public async Task<UpdatedAccountForeignLanguageResponse> Update(UpdateAccountForeignLanguageRequest updateAccountForeignLanguageRequest)
        {
            AccountForeignLanguage accountForeignLanguage = _mapper.Map<AccountForeignLanguage>(updateAccountForeignLanguageRequest);
            var updatedAccountForeignLanguage = await _accountForeignLanguageDal.UpdateAsync(accountForeignLanguage);
            UpdatedAccountForeignLanguageResponse result = _mapper.Map<UpdatedAccountForeignLanguageResponse>(updatedAccountForeignLanguage);
            return result;
        }
    }
}
