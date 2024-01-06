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

        public async Task<CreatedSkillResponse> Add(CreateSkillRequest createSkillRequest)
        {
            Skill skill = _mapper.Map<Skill>(createSkillRequest);
            var cretedSkill = await _skillDal.AddAsync(skill);
            CreatedSkillResponse result = _mapper.Map<CreatedSkillResponse>(cretedSkill);
            return result;

        }

        public async Task<DeletedSkillResponse> Delete(DeleteSkillRequest deleteSkillRequest)
        {
            Skill skill = _mapper.Map<Skill>(deleteSkillRequest);
            var deletedSkill = await _skillDal.DeleteAsync(skill, false);
            DeletedSkillResponse result = _mapper.Map<DeletedSkillResponse>(deletedSkill);
            return result;
        }

        public async Task<IPaginate<GetListSkillResponse>> GetListSkillInformation(PageRequest pageRequest)
        {
            var skill = await _skillDal.GetListAsync(
                orderBy: s => s.OrderBy(s => s.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListSkillResponse>>(skill);
            return result;
        }

        public async Task<UpdatedSkillResponse> Update(UpdateSkillRequest updateSkillRequest)
        {
            Skill skill = _mapper.Map<Skill>(updateSkillRequest);
            var updatedSkill = await _skillDal.UpdateAsync(skill);
            UpdatedSkillResponse result = _mapper.Map<UpdatedSkillResponse>(updatedSkill);
            return result;
        }
    }
}
