using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class QuestionCategoryManager : IQuestionCategoryService
    {
        IQuestionCategoryDal _questionCategoryDal;
        IMapper _mapper;

        public QuestionCategoryManager(IQuestionCategoryDal questionCategoryDal, IMapper mapper)
        {
            _questionCategoryDal = questionCategoryDal;
            _mapper = mapper;
        }

        public async Task<CreatedQuestionCategoryResponse> Add(CreateQuestionCategoryRequest createQuestionCategoryRequest)
        {
            QuestionCategory questionCategory = _mapper.Map<QuestionCategory>(createQuestionCategoryRequest);
            var createdQuestionCategory = await _questionCategoryDal.AddAsync(questionCategory);
            CreatedQuestionCategoryResponse result = _mapper.Map<CreatedQuestionCategoryResponse>(createdQuestionCategory);
            return result;
        }

        public async Task<DeletedQuestionCategoryResponse> Delete(DeleteQuestionCategoryRequest deleteQuestionCategoryRequest)
        {
            QuestionCategory questionCategory = _mapper.Map<QuestionCategory>(deleteQuestionCategoryRequest);
            var deletedQuestionCategory = await _questionCategoryDal.DeleteAsync(questionCategory, true);
            DeletedQuestionCategoryResponse result = _mapper.Map<DeletedQuestionCategoryResponse>(deletedQuestionCategory);
            return result;
        }

        public async Task<IPaginate<GetListQuestionCategoryResponse>> GetQuestionCategoryListAsync(PageRequest pageRequest)
        {
            var questionCategories = await _questionCategoryDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListQuestionCategoryResponse>>(questionCategories);
            return result;

        }

        public async Task<UpdatedQuestionCategoryResponse> Update(UpdateQuestionCategoryRequest updateQuestionCategoryRequest)
        {
            QuestionCategory questionCategory = _mapper.Map<QuestionCategory>(updateQuestionCategoryRequest);
            var updatedQuestionCategory = await _questionCategoryDal.UpdateAsync(questionCategory);
            UpdatedQuestionCategoryResponse result = _mapper.Map<UpdatedQuestionCategoryResponse>(updatedQuestionCategory);
            return result;
        }
    }
}
