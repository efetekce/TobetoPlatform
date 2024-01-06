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
    public interface ISubLectureService
    {
        Task<IPaginate<GetListSubLectureResponse>> GetListSubLecture(PageRequest pageRequest);
        Task<CreatedSubLectureResponse> Add(CreateSubLectureRequest createSubLectureRequest);
        Task<UpdatedSubLectureResponse> Update(UpdateSubLectureRequest updateSubLectureRequest);
        Task<DeletedSubLectureResponse> Delete(DeleteSubLectureRequest deleteSubLectureRequest);
    }
}
