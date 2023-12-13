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
    public class EducationManager : IEducationService
    {
        IEducationDal _educationDal;
        IMapper _mapper;
        //EducationBusinessRules _educationBusinessRules;

        public EducationManager(IEducationDal educationDal, IMapper mapper)
        {
            //_educationBusinessRules = educationBusinessRules;
            _educationDal = educationDal;
            _mapper = mapper;
        }

        public async Task<CreatedEducationResponse> Add(CreateEducationRequest createEducationRequest)
        {           
            var education = _mapper.Map<Education>(createEducationRequest);
            var createdEducation = await _educationDal.AddAsync(education);
            var createdEducationResponse = _mapper.Map<CreatedEducationResponse>(createdEducation);
            return createdEducationResponse;
        }

        public async Task<DeletedEducationResponse> Delete(DeleteEducationRequest deleteEducationRequest)
        {
            var education = _mapper.Map<Education>(deleteEducationRequest);
            var deletedEducation = await _educationDal.DeleteAsync(education, true);
            var deletedEducationResponse = _mapper.Map<DeletedEducationResponse>(deletedEducation);
            return deletedEducationResponse;
        }

        public async Task<UpdatedEducationResponse> Update(UpdateEducationRequest updateEducationRequest)
        {
            var education = _mapper.Map<Education>(updateEducationRequest);
            var updatedEducation = await _educationDal.UpdateAsync(education);
            var updatedEducationResponse = _mapper.Map<UpdatedEducationResponse>(updatedEducation);
            return updatedEducationResponse;
        }

        public async Task<IPaginate<GetListEducationResponse>> GetEducationListAsync(PageRequest pageRequest)
        {
            var educationList = await _educationDal.GetListAsync();
            var mappedList = _mapper.Map<Paginate<GetListEducationResponse>>(educationList);
            return mappedList;
        }
    }
}
