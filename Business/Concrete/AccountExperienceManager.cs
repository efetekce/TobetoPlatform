using AutoMapper;
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AccountExperienceManager : IAccountExperienceService
    {
        IAccountExperienceDal _accountExperienceDal;
        IMapper _mapper;
        AccountExperienceBusinessRules _accountExperienceBusinessRules;

        public AccountExperienceManager(IAccountExperienceDal accountExperienceDal, IMapper mapper,AccountExperienceBusinessRules accountExperienceBusinessRules)
        {
            _accountExperienceDal = accountExperienceDal;
            _mapper = mapper;
            _accountExperienceBusinessRules = accountExperienceBusinessRules;
        }

        [ValidationAspect(typeof(AccountExperienceValidator))]
        public async Task<CreatedAccountExperienceResponse> Add(CreateAccountExperienceRequest createAccountExperienceRequest)
        {
            await _accountExperienceBusinessRules.ExperienceRule(createAccountExperienceRequest.Position, createAccountExperienceRequest.CompanyName, createAccountExperienceRequest.CityId);
            AccountExperience accountExperience = _mapper.Map<AccountExperience>(createAccountExperienceRequest);
            var createdAccountExperience = await _accountExperienceDal.AddAsync(accountExperience);
            var createdAccountExperienceResponse = _mapper.Map<CreatedAccountExperienceResponse>(createdAccountExperience);
            return createdAccountExperienceResponse;
        }

        public async Task<DeletedAccountExperienceResponse> Delete(DeleteAccountExperienceRequest deleteAccountExperienceRequest)
        {
            //AccountExperience accountExperience = _mapper.Map<AccountExperience>(deleteAccountExperienceRequest);
            AccountExperience accountExperience = await _accountExperienceDal.GetAsync(d => d.Id == deleteAccountExperienceRequest.Id);
            var deletedAccountExperience = await _accountExperienceDal.DeleteAsync(accountExperience, false);
            var deletedAccountExperienceResponse = _mapper.Map<DeletedAccountExperienceResponse>(deletedAccountExperience);
            return deletedAccountExperienceResponse;

        }

        public async Task<IPaginate<GetListAccountExperienceResponse>> GetListAccountExperience(PageRequest pageRequest)
        {
            var experiences = await _accountExperienceDal.GetListAsync(
                orderBy: e => e.OrderBy(e => e.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var mapped = _mapper.Map<Paginate<GetListAccountExperienceResponse>>(experiences);
            return mapped;
        }

        public async Task<UpdatedAccountExperienceResponse> Update(UpdateAccountExperienceRequest updateAccountExperienceRequest)
        {
            //var category = _mapper.Map<AccountExperience>(updateExperienceRequest);
            AccountExperience accountExperience = await _accountExperienceDal.GetAsync(i => i.Id == updateAccountExperienceRequest.Id);
            _mapper.Map(updateAccountExperienceRequest, accountExperience);
            var updatedAccountExperience = await _accountExperienceDal.UpdateAsync(accountExperience);
            var updatedAccountExperienceResponse = _mapper.Map<UpdatedAccountExperienceResponse>(updatedAccountExperience);
            return updatedAccountExperienceResponse;
        }
    }
}
