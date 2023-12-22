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
    public class QuestionManager : IQuestionService
    {
        IQuestionDal _questionDal;
        IMapper _mapper;

        public QuestionManager(IQuestionDal questionDal, IMapper mapper)
        {
            _questionDal = questionDal;
            _mapper = mapper;
        }

        public async Task<CreatedQuestionResponse> Add(CreateQuestionRequest createQuestionRequest)
        {
            Question question = _mapper.Map<Question>(createQuestionRequest);
            var createdQuestion = await _questionDal.AddAsync(question);
            CreatedQuestionResponse result = _mapper.Map<CreatedQuestionResponse>(createdQuestion);
            return result;
        }

        public async Task<DeletedQuestionResponse> Delete(DeleteQuestionRequest deleteQuestionRequest)
        {
            Question question = _mapper.Map<Question>(deleteQuestionRequest);
            var deletedQuestion = await _questionDal.DeleteAsync(question, true);
            DeletedQuestionResponse result = _mapper.Map<DeletedQuestionResponse>(deletedQuestion);
            return result;
        }

        public async Task<IPaginate<GetListQuestionResponse>> GetQuestionListAsync()
        {
            var questions = await _questionDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListQuestionResponse>>(questions);
            return result;

        }

        public async Task<UpdatedQuestionResponse> Update(UpdateQuestionRequest updateQuestionRequest)
        {
            Question question = _mapper.Map<Question>(updateQuestionRequest);
            var updatedQuestion = await _questionDal.UpdateAsync(question);
            UpdatedQuestionResponse result = _mapper.Map<UpdatedQuestionResponse>(updatedQuestion);
            return result;
        }
    }
}
