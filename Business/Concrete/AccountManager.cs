﻿using AutoMapper;
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
    public class AccountManager : IAccountService
    {
        IAccountDal _accountDal;
        IMapper _mapper;
        public AccountManager(IAccountDal accountDal,IMapper mapper)
        {
            _accountDal = accountDal;
            _mapper = mapper;   
        }
        public async Task<CreatedAccountResponse> Add(CreateAccountRequest createAccountRequest)
        {
            Account account = _mapper.Map<Account>(createAccountRequest);
        var createdAccount=await _accountDal.AddAsync(account);
            CreatedAccountResponse result=_mapper.Map<CreatedAccountResponse>(createdAccount);
            return result;
        }

        public async Task<DeletedAccountResponse> Delete(DeleteAccountRequest deleteAccountRequest)
        {
            Account account = _mapper.Map<Account>(deleteAccountRequest);
            var deletedAccount = await _accountDal.DeleteAsync(account,false);
            DeletedAccountResponse result = _mapper.Map<DeletedAccountResponse>(deletedAccount);
            return result;
        }

        public async Task<IPaginate<GetListAccountResponse>> GetListAccount()
        {
            var account = await _accountDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListAccountResponse>>(account);
            return result;
        }

        public async Task<UpdatedAccountResponse> Update(UpdateAccountRequest updateAccountRequest)
        {
            Account account = _mapper.Map<Account>(updateAccountRequest);
            var updatedAccount = await _accountDal.UpdateAsync(account);
            UpdatedAccountResponse result = _mapper.Map<UpdatedAccountResponse>(updatedAccount);
            return result;
        }
    }
}