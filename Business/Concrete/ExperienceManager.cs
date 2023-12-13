using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Business.Rules;
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
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;
        IMapper _mapper;
        //ExperienceBusinessRules _experienceBusinessRules;

        public ExperienceManager(IExperienceDal experienceDal, IMapper mapper)
        {
            _experienceDal = experienceDal;
            _mapper = mapper;
            //_experienceBusinessRules = experienceBusinessRules;
        }

        public async Task<CreatedExperienceResponse> Add(CreateExperienceRequest createExperienceRequest)
        {
            var category = _mapper.Map<Experience>(createExperienceRequest);
            var createdCategory = await _experienceDal.AddAsync(category);
            var createdCategoryResponse = _mapper.Map<CreatedExperienceResponse>(createdCategory);
            return createdCategoryResponse;
        }

        public async Task<DeletedExperienceResponse> Delete(DeleteExperienceRequest deleteExperienceRequest)
        {
            var experience = _mapper.Map<Experience>(deleteExperienceRequest);
            var deletedExperience = await _experienceDal.DeleteAsync(experience, true);
            var deletedExperienceResponse = _mapper.Map<DeletedExperienceResponse>(deletedExperience);
            return deletedExperienceResponse;

        }

        public async Task<IPaginate<GetListExperienceResponse>> GetExperienceListAsync(PageRequest pageRequest)
        {
            var experiences = await _experienceDal.GetListAsync();
            var mapped = _mapper.Map<Paginate<GetListExperienceResponse>>(experiences);
            return mapped;
        }

        public async Task<UpdatedExperienceResponse> Update(UpdateExperienceRequest updateExperienceRequest)
        {
            var category = _mapper.Map<Experience>(updateExperienceRequest);
            var updatedExperience = await _experienceDal.UpdateAsync(category);
            var updatedExperienceResponse = _mapper.Map<UpdatedExperienceResponse>(updatedExperience);
            return updatedExperienceResponse;
        }
    }
}
