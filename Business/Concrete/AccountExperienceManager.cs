using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Business.Rules;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
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
        IAccountExperienceDal _experienceDal;
        IMapper _mapper;
        ExperienceBusinessRules _experienceBusinessRules;

        public AccountExperienceManager(IAccountExperienceDal experienceDal, IMapper mapper,ExperienceBusinessRules experienceBusinessRules)
        {
            _experienceDal = experienceDal;
            _mapper = mapper;
            _experienceBusinessRules = experienceBusinessRules;
        }

        [ValidationAspect(typeof(AccountExperienceValidator))]
        public async Task<CreatedExperienceResponse> Add(CreateAccountExperienceRequest createExperienceRequest)
        {
            await _experienceBusinessRules.ExperienceRule(createExperienceRequest.Position,createExperienceRequest.CompanyName,createExperienceRequest.CityId);
            var category = _mapper.Map<AccountExperience>(createExperienceRequest);
            var createdCategory = await _experienceDal.AddAsync(category);
            var createdCategoryResponse = _mapper.Map<CreatedExperienceResponse>(createdCategory);
            return createdCategoryResponse;
        }

        public async Task<DeletedExperienceResponse> Delete(DeleteAccountExperienceRequest deleteExperienceRequest)
        {
            var experience = _mapper.Map<AccountExperience>(deleteExperienceRequest);
            var deletedExperience = await _experienceDal.DeleteAsync(experience, false);
            var deletedExperienceResponse = _mapper.Map<DeletedExperienceResponse>(deletedExperience);
            return deletedExperienceResponse;

        }

        public async Task<IPaginate<GetListExperienceResponse>> GetListExperience(PageRequest pageRequest)
        {
            var experiences = await _experienceDal.GetListAsync(
                orderBy: e => e.OrderBy(e => e.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var mapped = _mapper.Map<Paginate<GetListExperienceResponse>>(experiences);
            return mapped;
        }

        public async Task<UpdatedExperienceResponse> Update(UpdateAccountExperienceRequest updateExperienceRequest)
        {
            var category = _mapper.Map<AccountExperience>(updateExperienceRequest);
            var updatedExperience = await _experienceDal.UpdateAsync(category);
            var updatedExperienceResponse = _mapper.Map<UpdatedExperienceResponse>(updatedExperience);
            return updatedExperienceResponse;
        }
    }
}
