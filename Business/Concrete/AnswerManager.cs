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
    public class AnswerManager : IAnswerService
    {
        IAnswerDal _answerDal;
        IMapper _mapper;

        public AnswerManager(IAnswerDal answerDal, IMapper mapper)
        {
            _answerDal = answerDal;
            _mapper = mapper;
        }

        public async Task<CreatedAnswerResponse> Add(CreateAnswerRequest createAnswerRequest)
        {
            Answer answer = _mapper.Map<Answer>(createAnswerRequest);
            var createdAnswer = await _answerDal.AddAsync(answer);
            CreatedAnswerResponse result = _mapper.Map<CreatedAnswerResponse>(createdAnswer);
            return result;
        }

        public async Task<DeletedAnswerResponse> Delete(DeleteAnswerRequest deleteAnswerRequest)
        {
            Answer answer = _mapper.Map<Answer>(deleteAnswerRequest);
            var deletedAnswer = await _answerDal.DeleteAsync(answer, true);
            DeletedAnswerResponse result = _mapper.Map<DeletedAnswerResponse>(deletedAnswer);
            return result;
        }

        public async Task<IPaginate<GetListAnswerResponse>> GetAnswerListAsync(PageRequest pageRequest)
        {
            var answers = await _answerDal.GetListAsync(
                orderBy: a => a.OrderBy(a => a.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListAnswerResponse>>(answers);
            return result;

        }

        public async Task<UpdatedAnswerResponse> Update(UpdateAnswerRequest updateAnswerRequest)
        {
            Answer answer = _mapper.Map<Answer>(updateAnswerRequest);
            var updatedAnswer = await _answerDal.UpdateAsync(answer);
            UpdatedAnswerResponse result = _mapper.Map<UpdatedAnswerResponse>(updatedAnswer);
            return result;
        }
    }
}
