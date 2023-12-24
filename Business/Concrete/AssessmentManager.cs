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
    public class AssessmentManager : IAssessmentService
    {
        IAssessmentDal _assessmentDal;
        IMapper _mapper;

        public AssessmentManager(IAssessmentDal assessmentDal, IMapper mapper)
        {
            _assessmentDal = assessmentDal;
            _mapper = mapper;
        }

        public async Task<CreatedAssessmentResponse> Add(CreateAssessmentRequest createAssessmentRequest)
        {
            Assessment assessment = _mapper.Map<Assessment>(createAssessmentRequest);
            var createdAssessment = await _assessmentDal.AddAsync(assessment);
            CreatedAssessmentResponse result = _mapper.Map<CreatedAssessmentResponse>(createdAssessment);
            return result;
        }

        public async Task<DeletedAssessmentResponse> Delete(DeleteAssessmentRequest deleteAssessmentRequest)
        {
            Assessment assessment = _mapper.Map<Assessment>(deleteAssessmentRequest);
            var deletedAssessment = await _assessmentDal.DeleteAsync(assessment, false);
            DeletedAssessmentResponse result = _mapper.Map<DeletedAssessmentResponse>(deletedAssessment);
            return result;
        }

        public async Task<IPaginate<GetListAssessmentResponse>> GetAssessmentListAsync(PageRequest pageRequest)
        {
            var assessments = await _assessmentDal.GetListAsync(
                orderBy: a => a.OrderBy(a => a.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListAssessmentResponse>>(assessments);
            return result;

        }

        public async Task<UpdatedAssessmentResponse> Update(UpdateAssessmentRequest updateAssessmentRequest)
        {
            Assessment assessment = _mapper.Map<Assessment>(updateAssessmentRequest);
            var updatedAssessment = await _assessmentDal.UpdateAsync(assessment);
            UpdatedAssessmentResponse result = _mapper.Map<UpdatedAssessmentResponse>(updatedAssessment);
            return result;
        }
    }
}
