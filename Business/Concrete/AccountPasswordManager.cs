using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Business.Rules;
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
    public class AccountPasswordManager : IAccountPasswordService
    {
        IAccountPasswordDal _accountPasswordDal;
        IMapper _mapper;
        //AccountPasswordBusinessRules _accountPasswordBusinessRules;

        public AccountPasswordManager(IAccountPasswordDal accountPasswordDal,
        IMapper mapper)
        {
            _accountPasswordDal = accountPasswordDal;
            _mapper = mapper;
            //_accountPasswordBusinessRules = accountPasswordBusinessRules;
        }

        public async Task<CreatedAccountPasswordResponse> Add(CreateAccountPasswordRequest createAccountPasswordRequest)
        {
            AccountPassword accountPassword = _mapper.Map<AccountPassword>(createAccountPasswordRequest);
            var createdAccountPassword = await _accountPasswordDal.AddAsync(accountPassword);
            CreatedAccountPasswordResponse result = _mapper.Map<CreatedAccountPasswordResponse>(createdAccountPassword);
            return result;
        }

        public async Task<DeletedAccountPasswordResponse> Delete(DeleteAccountPasswordRequest deleteAccountPasswordRequest)
        {
            AccountPassword accountPassword = _mapper.Map<AccountPassword>(deleteAccountPasswordRequest);
            var deletedAccountPassword = await _accountPasswordDal.DeleteAsync(accountPassword);
            DeletedAccountPasswordResponse result = _mapper.Map<DeletedAccountPasswordResponse>(deletedAccountPassword);
            return result;
        }

        public async Task<IPaginate<GetListAccountPasswordResponse>> GetListAccountPassword(PageRequest pageRequest)
        {
            var accountPassword = await _accountPasswordDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListAccountPasswordResponse>>(accountPassword);
            return result;
        }

        public async Task<UpdatedAccountPasswordResponse> Update(UpdateAccountPasswordRequest updateAccountPasswordRequest)
        {
            AccountPassword accountPassword = _mapper.Map<AccountPassword>(updateAccountPasswordRequest);
            var updatedAccountPassword = await _accountPasswordDal.UpdateAsync(accountPassword);
            UpdatedAccountPasswordResponse result = _mapper.Map<UpdatedAccountPasswordResponse>(updatedAccountPassword);
            return result;
        }
    }
}
