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
    public interface IQuestionService
    {
        Task<CreatedQuestionResponse> Add(CreateQuestionRequest createQuestionRequest);

        Task<IPaginate<GetListQuestionResponse>> GetQuestionListAsync(PageRequest pageRequest);

        Task<UpdatedQuestionResponse> Update(UpdateQuestionRequest updateQuestionRequest);

        Task<DeletedQuestionResponse> Delete(DeleteQuestionRequest deleteQuestionRequest);
    }
}
