using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AccountCourseLessonManager : IAccountCourseLessonService
    {

        IAccountCourseLessonDal _accountCourseLessonDal;
        IMapper _mapper;
        AccountCourseLessonBusinessRules _accountCourseLessonBusinessRules;
        public AccountCourseLessonManager(IAccountCourseLessonDal accountCourseLessonDal, IMapper mapper, AccountCourseLessonBusinessRules accountCourseLessonBusinessRules)
        {
            _accountCourseLessonDal = accountCourseLessonDal;
            _mapper = mapper;
            _accountCourseLessonBusinessRules = accountCourseLessonBusinessRules;
        }

        public async Task<CreatedAccountCourseLessonResponse> Add(CreateAccountCourseLessonRequest createAccountCourseLessonRequest)
        {
            await _accountCourseLessonBusinessRules.MustBeAccountDefined(createAccountCourseLessonRequest.AccountId);
            await _accountCourseLessonBusinessRules.MustBeLessonDefined(createAccountCourseLessonRequest.LessonId);
            await _accountCourseLessonBusinessRules.MustBeLessonStatusDefined(createAccountCourseLessonRequest.LessonStatusId);

            AccountCourseLesson accountCourseLesson = _mapper.Map<AccountCourseLesson>(createAccountCourseLessonRequest);
            var createdAccountCourseLesson = await _accountCourseLessonDal.AddAsync(accountCourseLesson);
            CreatedAccountCourseLessonResponse result = _mapper.Map<CreatedAccountCourseLessonResponse>(createdAccountCourseLesson);
            return result;
        }

        public async Task<DeletedAccountCourseLessonResponse> Delete(DeleteAccountCourseLessonRequest deleteAccountCourseLessonRequest)
        {
            AccountCourseLesson accountCourseLesson = _mapper.Map<AccountCourseLesson>(deleteAccountCourseLessonRequest);
            var deletedAccountCourseLesson = await _accountCourseLessonDal.DeleteAsync(accountCourseLesson, false);
            DeletedAccountCourseLessonResponse result = _mapper.Map<DeletedAccountCourseLessonResponse>(deletedAccountCourseLesson);
            return result;
        }

        public async Task<IPaginate<GetListAccountCourseLessonResponse>> GetListAccountCourseLesson()
        {
            var accountCourseLesson = await _accountCourseLessonDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListAccountCourseLessonResponse>>(accountCourseLesson);
            return result;
        }

        public async Task<UpdatedAccountCourseLessonResponse> Update(UpdateAccountCourseLessonRequest updateAccountCourseLessonRequest)
        {
            await _accountCourseLessonBusinessRules.MustBeAccountDefined(updateAccountCourseLessonRequest.AccountId);
            await _accountCourseLessonBusinessRules.MustBeLessonDefined(updateAccountCourseLessonRequest.LessonId);
            await _accountCourseLessonBusinessRules.MustBeLessonStatusDefined(updateAccountCourseLessonRequest.LessonStatusId);

            AccountCourseLesson accountCourseLesson = _mapper.Map<AccountCourseLesson>(updateAccountCourseLessonRequest);
            var updatedAccountCourseLesson = await _accountCourseLessonDal.UpdateAsync(accountCourseLesson);
            UpdatedAccountCourseLessonResponse result = _mapper.Map<UpdatedAccountCourseLessonResponse>(updatedAccountCourseLesson);
            return result;
        }
    }
}
