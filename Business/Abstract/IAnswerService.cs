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
    public interface IAnswerService
    {
        Task<CreatedAnswerResponse> Add(CreateAnswerRequest createAnswerRequest);

        Task<IPaginate<GetListAnswerResponse>> GetAnswerListAsync();

        Task<UpdatedAnswerResponse> Update(UpdateAnswerRequest updateAnswerRequest);

        Task<DeletedAnswerResponse> Delete(DeleteAnswerRequest deleteAnswerRequest);
    }
}
