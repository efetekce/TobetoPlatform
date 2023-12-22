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
    public interface IAccountCourseService
    {
        Task<CreatedAccountCourseResponse> Add(CreateAccountCourseRequest createAccountCourseRequest);
        Task<IPaginate<GetListAccountCourseResponse>> GetListAccountCourse(PageRequest pageRequest);
        Task<UpdatedAccountCourseResponse> Update(UpdateAccountCourseRequest updateAccountCourseRequest);
        Task<DeletedAccountCourseResponse> Delete(DeleteAccountCourseRequest deleteAccountCourseRequest);
    }
}
