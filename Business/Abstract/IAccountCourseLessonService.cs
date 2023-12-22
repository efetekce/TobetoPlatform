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
    public interface IAccountCourseLessonService
    {
        Task<CreatedAccountCourseLessonResponse> Add(CreateAccountCourseLessonRequest createAccountCourseLessonRequest);
        Task<IPaginate<GetListAccountCourseLessonResponse>> GetListAccountCourseLesson();
        Task<UpdatedAccountCourseLessonResponse> Update(UpdateAccountCourseLessonRequest updateAccountCourseLessonRequest);
        Task<DeletedAccountCourseLessonResponse> Delete(DeleteAccountCourseLessonRequest deleteAccountCourseLessonRequest);
    }
}
