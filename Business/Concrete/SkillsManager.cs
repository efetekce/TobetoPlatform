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
    public class SkillsManager : ISkillsService
    {
        ISkillsDal _skillsDal;
        IMapper _mapper;

        public SkillsManager(ISkillsDal skillsDal, IMapper mapper)
        {
            _skillsDal = skillsDal;
            _mapper = mapper;
        }

        public async Task<CreatedSkillsResponse> Add(CreateSkillsRequest createdSkillsRequest)
        {
            var skills = _mapper.Map<Skills>(createdSkillsRequest);
            var createdSkills = await _skillsDal.AddAsync(skills);
            var createdSkillsResponse = _mapper.Map<CreatedSkillsResponse>(createdSkills);
            return createdSkillsResponse;
        }

        public async Task<DeletedSkillsResponse> Delete(DeleteSkillsRequest deleteSkillsRequest)
        {
            var skills = _mapper.Map<Skills>(deleteSkillsRequest);
            var deletedSkills = await _skillsDal.DeleteAsync(skills, true);
            var deletedSkillsResponse = _mapper.Map<DeletedSkillsResponse>(deletedSkills);
            return deletedSkillsResponse;
        }

        public async Task<IPaginate<GetListSkillsResponse>> GetListSkills()
        {
            var skills = await _skillsDal.GetListAsync();
            var mapped = _mapper.Map<Paginate<GetListSkillsResponse>>(skills);
            return mapped;
        }

        public async Task<UpdatedSkillsResponse> Update(UpdateSkillsRequest updatedSkillsRequest)
        {
            var skills = _mapper.Map<Skills>(updatedSkillsRequest);
            var updateSkill = await _skillsDal.UpdateAsync(skills);
            var updatedSkillResponse = _mapper.Map<UpdatedSkillsResponse>(updateSkill);
            return updatedSkillResponse;
        }
    }
}
