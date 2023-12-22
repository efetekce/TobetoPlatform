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
    public class AccountCourseManager : IAccountCourseService
    {

        IAccountCourseDal _accountCourseDal;
        IMapper _mapper;
        AccountCourseBusinessRules _accountCourseBusinessRules;
        public AccountCourseManager(IAccountCourseDal accountCourseDal, IMapper mapper, AccountCourseBusinessRules accountCourseBusinessRules)
        {
            _accountCourseDal = accountCourseDal;
            _mapper = mapper;
            _accountCourseBusinessRules = accountCourseBusinessRules;
        }

        public async Task<CreatedAccountCourseResponse> Add(CreateAccountCourseRequest createAccountCourseRequest)
        {
            await _accountCourseBusinessRules.MustBeAccountDefined(createAccountCourseRequest.AccountId);
            await _accountCourseBusinessRules.MustBeCourseDefined(createAccountCourseRequest.CourseId);

            AccountCourse accountCourse = _mapper.Map<AccountCourse>(createAccountCourseRequest);
            var createdAccountCourse = await _accountCourseDal.AddAsync(accountCourse);
            CreatedAccountCourseResponse result = _mapper.Map<CreatedAccountCourseResponse>(createdAccountCourse);
            return result;
        }

        public async Task<DeletedAccountCourseResponse> Delete(DeleteAccountCourseRequest deleteAccountCourseRequest)
        {
            AccountCourse accountCourse = _mapper.Map<AccountCourse>(deleteAccountCourseRequest);
            var deletedAccountCourse = await _accountCourseDal.DeleteAsync(accountCourse, false);
            DeletedAccountCourseResponse result = _mapper.Map<DeletedAccountCourseResponse>(deletedAccountCourse);
            return result;
        }

        public async Task<IPaginate<GetListAccountCourseResponse>> GetListAccountCourse()
        {
            var accountCourse = await _accountCourseDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListAccountCourseResponse>>(accountCourse);
            return result;
        }

        public async Task<UpdatedAccountCourseResponse> Update(UpdateAccountCourseRequest updateAccountCourseRequest)
        {
            await _accountCourseBusinessRules.MustBeAccountDefined(updateAccountCourseRequest.AccountId);
            await _accountCourseBusinessRules.MustBeCourseDefined(updateAccountCourseRequest.CourseId);

            AccountCourse accountCourse = _mapper.Map<AccountCourse>(updateAccountCourseRequest);
            var updatedAccountCourse = await _accountCourseDal.UpdateAsync(accountCourse);
            UpdatedAccountCourseResponse result = _mapper.Map<UpdatedAccountCourseResponse>(updatedAccountCourse);
            return result;
        }
    }
}
