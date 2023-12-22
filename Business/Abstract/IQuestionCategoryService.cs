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
    public interface IQuestionCategoryService
    {
        Task<CreatedQuestionCategoryResponse> Add(CreateQuestionCategoryRequest createQuestionCategoryRequest);

        Task<IPaginate<GetListQuestionCategoryResponse>> GetQuestionCategoryListAsync(PageRequest pageRequest);

        Task<UpdatedQuestionCategoryResponse> Update(UpdateQuestionCategoryRequest updateQuestionCategoryRequest);

        Task<DeletedQuestionCategoryResponse> Delete(DeleteQuestionCategoryRequest deleteQuestionCategoryRequest);
    }
}
