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
    public class EducationProgramManager : IEducationProgramService
    {
        IEducationProgramDal _educationProgramDal;
        IMapper _mapper;
        //EducationProgramBusinessRules _educationProgramBusinessRules;

        public EducationProgramManager(IEducationProgramDal educationProgramDal,
        IMapper mapper)
        {
            _educationProgramDal = educationProgramDal;
            _mapper = mapper;
            //_educationProgramBusinessRules = educationProgramBusinessRules;
        }

        public async Task<CreatedEducationProgramResponse> Add(CreateEducationProgramRequest createEducationProgramRequest)
        {
            EducationProgram educationProgram = _mapper.Map<EducationProgram>(createEducationProgramRequest);
            var createdEducationProgram = await _educationProgramDal.AddAsync(educationProgram);
            CreatedEducationProgramResponse result = _mapper.Map<CreatedEducationProgramResponse>(createdEducationProgram);
            return result;
        }

        public async Task<DeletedEducationProgramResponse> Delete(DeleteEducationProgramRequest deleteEducationProgramRequest)
        {
            EducationProgram educationProgram = _mapper.Map<EducationProgram>(deleteEducationProgramRequest);
            var deletedEducationProgram = await _educationProgramDal.DeleteAsync(educationProgram);
            DeletedEducationProgramResponse result = _mapper.Map<DeletedEducationProgramResponse>(deletedEducationProgram);
            return result;
        }

        public async Task<IPaginate<GetListEducationProgramResponse>> GetListEducationProgram()
        {
            var educationProgram = await _educationProgramDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListEducationProgramResponse>>(educationProgram);
            return result;
        }

        public async Task<UpdatedEducationProgramResponse> Update(UpdateEducationProgramRequest updateEducationProgramRequest)
        {
            EducationProgram educationProgram = _mapper.Map<EducationProgram>(updateEducationProgramRequest);
            var updatedEducationProgram = await _educationProgramDal.UpdateAsync(educationProgram);
            UpdatedEducationProgramResponse result = _mapper.Map<UpdatedEducationProgramResponse>(updatedEducationProgram);
            return result;
        }
    }
}
