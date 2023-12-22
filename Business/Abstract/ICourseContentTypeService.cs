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
    public interface ICourseContentTypeService
    {
        Task<CreatedCourseContentTypeResponse> Add(CreateCourseContentTypeRequest createCourseContentTypeRequest);
        Task<IPaginate<GetListCourseContentTypeResponse>> GetListCourseContentType();
        Task<UpdatedCourseContentTypeResponse> Update(UpdateCourseContentTypeRequest updateCourseContentTypeRequest);
        Task<DeletedCourseContentTypeResponse> Delete(DeleteCourseContentTypeRequest deleteCourseContentTypeRequest);
    }
}
