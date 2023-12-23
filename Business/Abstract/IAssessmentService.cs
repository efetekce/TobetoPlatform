using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAssessmentService
    {
        Task<CreatedAssessmentResponse> Add(CreateAssessmentRequest createAssessmentRequest);

        Task<IPaginate<GetListAssessmentResponse>> GetAssessmentListAsync(PageRequest pageRequest);

        Task<UpdatedAssessmentResponse> Update(UpdateAssessmentRequest updateAssessmentRequest);

        Task<DeletedAssessmentResponse> Delete(DeleteAssessmentRequest deleteAssessmentRequest);
    }
}
