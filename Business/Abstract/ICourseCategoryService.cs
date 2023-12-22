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
    public interface ICourseCategoryService
    {
        Task<CreatedCourseCategoryResponse> Add(CreateCourseCategoryRequest createCourseCategoryRequest);
        Task<IPaginate<GetListCourseCategoryResponse>> GetListCourseCategory();
        Task<UpdatedCourseCategoryResponse> Update(UpdateCourseCategoryRequest updateCourseCategoryRequest);
        Task<DeletedCourseCategoryResponse> Delete(DeleteCourseCategoryRequest deleteCourseCategoryRequest);
    }
}
