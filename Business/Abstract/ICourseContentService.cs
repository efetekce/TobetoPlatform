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
    public interface ICourseContentService
    {
        Task<CreatedCourseContentResponse> Add(CreateCourseContentRequest createCourseContentRequest);
        Task<IPaginate<GetListCourseContentResponse>> GetListCourseContent(PageRequest pageRequest);
        Task<UpdatedCourseContentResponse> Update(UpdateCourseContentRequest updateCourseContentRequest);
        Task<DeletedCourseContentResponse> Delete(DeleteCourseContentRequest deleteCourseContentRequest);
    }
}
