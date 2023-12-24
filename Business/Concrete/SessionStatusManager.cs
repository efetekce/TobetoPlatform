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
    public class SessionStatusManager : ISessionStatusService
    {
        ISessionStatusDal _sessionStatusDal;
        IMapper _mapper;
        //SessionStatusBusinessRules _sessionStatusBusinessRules;

        public SessionStatusManager(ISessionStatusDal sessionStatusDal,IMapper mapper)
        {
            _sessionStatusDal = sessionStatusDal;
            _mapper = mapper;
            //_sessionStatusBusinessRules = sessionStatusBusinessRules;
        }

        public async Task<CreatedSessionStatusResponse> Add(CreateSessionStatusRequest createSessionStatusRequest)
        {
            SessionStatus sessionStatus = _mapper.Map<SessionStatus>(createSessionStatusRequest);
            var createdSessionStatus = await _sessionStatusDal.AddAsync(sessionStatus);
            CreatedSessionStatusResponse result = _mapper.Map<CreatedSessionStatusResponse>(createdSessionStatus);
            return result;
        }

        public async Task<DeletedSessionStatusResponse> Delete(DeleteSessionStatusRequest deleteSessionStatusRequest)
        {
            SessionStatus sessionStatus = _mapper.Map<SessionStatus>(deleteSessionStatusRequest);
            var deletedSessionStatus = await _sessionStatusDal.DeleteAsync(sessionStatus, false);
            DeletedSessionStatusResponse result = _mapper.Map<DeletedSessionStatusResponse>(deletedSessionStatus);
            return result;
        }

        public async Task<IPaginate<GetListSessionStatusResponse>> GetListSessionStatus(PageRequest pageRequest)
        {
            var sessionStatus = await _sessionStatusDal.GetListAsync(
                orderBy: s => s.OrderBy(s => s.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListSessionStatusResponse>>(sessionStatus);
            return result;
        }

        public async Task<UpdatedSessionStatusResponse> Update(UpdateSessionStatusRequest updateSessionStatusRequest)
        {
            SessionStatus sessionStatus = _mapper.Map<SessionStatus>(updateSessionStatusRequest);
            var deletedSessionStatus = await _sessionStatusDal.UpdateAsync(sessionStatus);
            UpdatedSessionStatusResponse result = _mapper.Map<UpdatedSessionStatusResponse>(deletedSessionStatus);
            return result;
        }
    }
}
