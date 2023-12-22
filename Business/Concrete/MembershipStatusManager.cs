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
    public class MembershipStatusManager : IMembershipStatusService
    {
        IMembershipStatusDal _membershipStatusDal;
        IMapper _mapper;
        //MembershipStatusBusinessRules _membershipStatusBusinessRules;

        public MembershipStatusManager(IMembershipStatusDal membershipStatusDal,
        IMapper mapper)
        {
            _membershipStatusDal = membershipStatusDal;
            _mapper = mapper;
                //_membershipStatusBusinessRules=membershipStatusBusinessRules;
        }

        public async Task<CreatedMembershipStatusResponse> Add(CreateMembershipStatusRequest createMembershipStatusRequest)
        {
            MembershipStatus membershipStatus = _mapper.Map<MembershipStatus>(createMembershipStatusRequest);
            var createdMembershipStatus=await _membershipStatusDal.AddAsync(membershipStatus);
            CreatedMembershipStatusResponse result = _mapper.Map<CreatedMembershipStatusResponse>(createdMembershipStatus);
            return result;
        }

        public async Task<DeletedMembershipStatusResponse> Delete(DeleteMembershipStatusRequest deleteMembershipStatusRequest)
        {
            MembershipStatus membershipStatus = _mapper.Map<MembershipStatus>(deleteMembershipStatusRequest);
            var deletedMembershipStatus = await _membershipStatusDal.DeleteAsync(membershipStatus);
            DeletedMembershipStatusResponse result=_mapper.Map<DeletedMembershipStatusResponse>(deletedMembershipStatus);
            return result;
        }

        public async Task<IPaginate<GetListMembershipStatusResponse>> GetListMembershipStatus(PageRequest pageRequest)
        {
            var membershipStatus = await _membershipStatusDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListMembershipStatusResponse>>(membershipStatus);
            return result;
        }

        public async Task<UpdatedMembershipStatusResponse> Update(UpdateMembershipStatusRequest updateMembershipStatusRequest)
        {
            MembershipStatus membershipStatus = _mapper.Map<MembershipStatus>(updateMembershipStatusRequest);
            var deletedMembershipStatus = await _membershipStatusDal.UpdateAsync(membershipStatus);
            UpdatedMembershipStatusResponse result = _mapper.Map<UpdatedMembershipStatusResponse>(deletedMembershipStatus);
            return result;
        }
    }
}
