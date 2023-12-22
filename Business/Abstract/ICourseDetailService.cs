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
    public interface ICourseDetailService
    {
        Task<CreatedCourseDetailResponse> Add(CreateCourseDetailRequest createCourseDetailRequest);
        Task<IPaginate<GetListCourseDetailResponse>> GetListCourseDetail();
        Task<UpdatedCourseDetailResponse> Update(UpdateCourseDetailRequest updateCourseDetailRequest);
        Task<DeletedCourseDetailResponse> Delete(DeleteCourseDetailRequest deleteCourseDetailRequest);
    }
}
