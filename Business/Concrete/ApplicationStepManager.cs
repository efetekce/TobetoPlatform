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
    public class ApplicationStepManager : IApplicationStepService
    {
        IApplicationStepDal _applicationStepDal;
        IMapper _mapper;
        //ApplicationBusinessRules _applicationBusinessRules;

        public ApplicationStepManager(IApplicationStepDal applicationStepDal,
        IMapper mapper)
        {
            _applicationStepDal = applicationStepDal;
            _mapper = mapper;
            //_applicationBusinessRules = applicationBusinessRules;
        }

        public async Task<CreatedApplicationStepResponse> Add(CreateApplicationStepRequest createApplicationStepRequest)
        {
            ApplicationStep applicationStep = _mapper.Map<ApplicationStep>(createApplicationStepRequest);
            var createdApplicationStep = await _applicationStepDal.AddAsync(applicationStep);
            CreatedApplicationStepResponse result = _mapper.Map<CreatedApplicationStepResponse>(createdApplicationStep);
            return result;
        }

        public async Task<DeletedApplicationStepResponse> Delete(DeleteApplicationStepRequest deleteApplicationStepRequest)
        {
            ApplicationStep applicationStep = _mapper.Map<ApplicationStep>(deleteApplicationStepRequest);
            var deletedApplicationStep = await _applicationStepDal.DeleteAsync(applicationStep);
            DeletedApplicationStepResponse result = _mapper.Map<DeletedApplicationStepResponse>(deletedApplicationStep);
            return result;
        }

        public async Task<IPaginate<GetListApplicationStepResponse>> GetListApplicationStep()
        {
            var applicationStep = await _applicationStepDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListApplicationStepResponse>>(applicationStep);
            return result;
        }

        public async Task<UpdatedApplicationStepResponse> Update(UpdateApplicationStepRequest updateApplicationStepRequest)
        {
            ApplicationStep applicationStep = _mapper.Map<ApplicationStep>(updateApplicationStepRequest);
            var updatedApplicationStep = await _applicationStepDal.UpdateAsync(applicationStep);
            UpdatedApplicationStepResponse result = _mapper.Map<UpdatedApplicationStepResponse>(updatedApplicationStep);
            return result;
        }
    }
}
