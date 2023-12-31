﻿using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Business.Rules;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concrete
{
    public class AccountSocialMediaManager : IAccountSocialMediaService
    {
        IAccountSocialMediaDal _accountSocialMediaDal;
        IMapper _mapper;
        AccountSocialMediaBusinessRules _accountSocialMediaBusinessRules;
        
        public AccountSocialMediaManager(IAccountSocialMediaDal accountSocialMediaDal,
        IMapper mapper, AccountSocialMediaBusinessRules accountSocialMediaBusinessRules)
        {
            _accountSocialMediaDal = accountSocialMediaDal;
            _mapper = mapper;
            _accountSocialMediaBusinessRules = accountSocialMediaBusinessRules;
        }

        [ValidationAspect(typeof(AccountSocialMediaValidator))]
        public async Task<CreatedAccountSocialMediaResponse> Add(CreateAccountSocialMediaRequest createAccountSocialMediaRequest)
        {
            await _accountSocialMediaBusinessRules.SameAccountSocialMediaLink(createAccountSocialMediaRequest.Link);
            AccountSocialMedia accountSocialMedia = _mapper.Map<AccountSocialMedia>(createAccountSocialMediaRequest);
            var createdAccountSocialMedia = await _accountSocialMediaDal.AddAsync(accountSocialMedia);
            CreatedAccountSocialMediaResponse result = _mapper.Map<CreatedAccountSocialMediaResponse>(createdAccountSocialMedia);
            return result;
        }

        public async Task<DeletedAccountSocialMediaResponse> Delete(DeleteAccountSocialMediaRequest deleteAccountSocialMediaRequest)
        {
            AccountSocialMedia accountSocialMedia = _mapper.Map<AccountSocialMedia>(deleteAccountSocialMediaRequest);
            var deletedAccountSocialMedia = await _accountSocialMediaDal.DeleteAsync(accountSocialMedia, false);
            DeletedAccountSocialMediaResponse result = _mapper.Map<DeletedAccountSocialMediaResponse>(deletedAccountSocialMedia);
            return result;
        }

        public async Task<IPaginate<GetListAccountSocialMediaResponse>> GetListAccountSocialMedia(PageRequest pageRequest)
        {
            var accountSocialMedia = await _accountSocialMediaDal.GetListAsync(
                orderBy: a => a.OrderBy(a => a.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListAccountSocialMediaResponse>>(accountSocialMedia);
            return result;
        }

        public async Task<UpdatedAccountSocialMediaResponse> Update(UpdateAccountSocialMediaRequest updateAccountSocialMediaRequest)
        {
            AccountSocialMedia accountSocialMedia = _mapper.Map<AccountSocialMedia>(updateAccountSocialMediaRequest);
            var updatedAccountSocialMedia = await _accountSocialMediaDal.UpdateAsync(accountSocialMedia);
            UpdatedAccountSocialMediaResponse result = _mapper.Map<UpdatedAccountSocialMediaResponse>(updatedAccountSocialMedia);
            return result;
        }
    }
}
