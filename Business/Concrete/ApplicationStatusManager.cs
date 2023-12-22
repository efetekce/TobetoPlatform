using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concrete
{
    public class ApplicationStatusManager : IApplicationStatusService
    {
        IApplicationStatusDal _applicationStatusDal;
        IMapper _mapper;
        //ApplicationBusinessRules _applicationBusinessRules;

        public ApplicationStatusManager(IApplicationStatusDal applicationStatusDal,
        IMapper mapper)
        {
            _applicationStatusDal = applicationStatusDal;
            _mapper = mapper;
            //_applicationBusinessRules = applicationBusinessRules;
        }

        public async Task<CreatedApplicationStatusResponse> Add(CreateApplicationStatusRequest createApplicationStatusRequest)
        {
            ApplicationStatus applicationStatus = _mapper.Map<ApplicationStatus>(createApplicationStatusRequest);
            var createdApplicationStatus = await _applicationStatusDal.AddAsync(applicationStatus);
            CreatedApplicationStatusResponse result = _mapper.Map<CreatedApplicationStatusResponse>(createdApplicationStatus);
            return result;
        }

        public async Task<DeletedApplicationStatusResponse> Delete(DeleteApplicationStatusRequest deleteApplicationStatusRequest)
        {
            ApplicationStatus applicationStatus = _mapper.Map<ApplicationStatus>(deleteApplicationStatusRequest);
            var deletedApplicationStatus = await _applicationStatusDal.DeleteAsync(applicationStatus);
            DeletedApplicationStatusResponse result = _mapper.Map<DeletedApplicationStatusResponse>(deletedApplicationStatus);
            return result;
        }

        public async Task<IPaginate<GetListApplicationStatusResponse>> GetListApplicationStatus(PageRequest pageRequest)
        {
            var applicationStatus = await _applicationStatusDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListApplicationStatusResponse>>(applicationStatus);
            return result;
        }

        public async Task<UpdatedApplicationStatusResponse> Update(UpdateApplicationStatusRequest updateApplicationStatusRequest)
        {
            ApplicationStatus applicationStatus = _mapper.Map<ApplicationStatus>(updateApplicationStatusRequest);
            var updatedApplicationStatus = await _applicationStatusDal.UpdateAsync(applicationStatus);
            UpdatedApplicationStatusResponse result = _mapper.Map<UpdatedApplicationStatusResponse>(updatedApplicationStatus);
            return result;
        }
    }
}
