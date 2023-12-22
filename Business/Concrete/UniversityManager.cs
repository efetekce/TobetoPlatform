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
    public class UniversityManager : IUniversityService
    {
        IUniversityDal _universityDal;
        IMapper _mapper;
        UniversityBusinessRules _universityBusinessRules;

        public UniversityManager(IUniversityDal universityDal,
        IMapper mapper,
        UniversityBusinessRules universityBusinessRules)
        {
            _universityDal = universityDal;
            _mapper = mapper;
            _universityBusinessRules = universityBusinessRules;
        }

        public async Task<CreatedUniversityResponse> Add(CreateUniversityRequest createUniversityRequest)
        {
            await _universityBusinessRules.SameUniversityName(createUniversityRequest.Name);
            University university = _mapper.Map<University>(createUniversityRequest);
            var createdUniversity = await _universityDal.AddAsync(university);
            CreatedUniversityResponse result = _mapper.Map<CreatedUniversityResponse>(createdUniversity);
            return result;
        }

        public async Task<DeletedUniversityResponse> Delete(DeleteUniversityRequest deleteUniversityRequest)
        {
            University university = _mapper.Map<University>(deleteUniversityRequest);
            var deletedUniversity = await _universityDal.DeleteAsync(university);
            DeletedUniversityResponse result = _mapper.Map<DeletedUniversityResponse>(deletedUniversity);
            return result;
        }

        public async Task<IPaginate<GetListUniversityResponse>> GetListUniversity()
        {
            var university = await _universityDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListUniversityResponse>>(university);
            return result;
        }

        public async Task<UpdatedUniversityResponse> Update(UpdateUniversityRequest updateUniversityRequest)
        {
            University university = _mapper.Map<University>(updateUniversityRequest);
            var updatedUniversity = await _universityDal.UpdateAsync(university);
            UpdatedUniversityResponse result = _mapper.Map<UpdatedUniversityResponse>(updatedUniversity);
            return result;
        }
    }
}
