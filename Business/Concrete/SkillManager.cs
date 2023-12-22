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
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;
        IMapper _mapper;

        public SkillManager(ISkillDal skilDal, IMapper mapper)
        {
            _skillDal = skilDal;
            _mapper = mapper;
        }

        public async Task<CreatedSkillsResponse> Add(CreateSkillRequest createSkillRequest)
        {
            Skill skill = _mapper.Map<Skill>(createSkillRequest);
            var cretedSkill = await _skillDal.AddAsync(skill);
            CreatedSkillsResponse result = _mapper.Map<CreatedSkillsResponse>(cretedSkill);
            return result;

        }

        public async Task<DeletedSkillsResponse> Delete(DeleteSkillsRequest deleteSkillsRequest)
        {
            Skill skill = _mapper.Map<Skill>(deleteSkillsRequest);
            var deletedSkill = await _skillDal.AddAsync(skill);
            DeletedSkillsResponse result = _mapper.Map<DeletedSkillsResponse>(deletedSkill);
            return result;
        }

        public async Task<IPaginate<GetListSkillResponse>> GetListSkillInformation(PageRequest pageRequest)
        {
            var skill = await _skillDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListSkillResponse>>(skill);
            return result;
        }

        public async Task<UpdatedSkillsResponse> Update(UpdateSkillsRequest updateSkillsRequest)
        {
            Skill skill = _mapper.Map<Skill>(updateSkillsRequest);
            var updatedSkill = await _skillDal.UpdateAsync(skill);
            UpdatedSkillsResponse result = _mapper.Map<UpdatedSkillsResponse>(updatedSkill);
            return result;
        }
    }
}
