﻿using Business.Abstract;
using Business.Concrete;
using Business.Rules;
using Business.ValidationRules.FluentValidation;
using Core.Security.JWT;
using DataAccess.Abstracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IAccountApplicationService, AccountApplicationManager>();
            services.AddScoped<IAccountCertificateService, AccountCertificateManager>();
            services.AddScoped<IAccountCourseService, AccountCourseManager>();
            services.AddScoped<IAccountCourseLessonService, AccountCourseLessonManager>();
            services.AddScoped<IAccountEducationService, AccountEducationManager>();
            services.AddScoped<IAccountForeignLanguageService, AccountForeignLanguageManager>();
            services.AddScoped<IAccountSkillService, AccountSkillManager>();
            services.AddScoped<IAccountSocialMediaService, AccountSocialMediaManager>();
            services.AddScoped<IAccountTestResultService, AccountTestResultManager>();
            services.AddScoped<IAddressService, AddressManager>();
            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementTypeService, AnnouncementTypeManager>();
            services.AddScoped<IAnswerService, AnswerManager>();
            services.AddScoped<IApplicationService, ApplicationManager>();
            services.AddScoped<IApplicationStepService, ApplicationStepManager>();
            services.AddScoped<IAssessmentService, AssessmentManager>();
            services.AddScoped<IAuthService, AuthManager>();
            services.AddScoped<ICityService, CityManager>();
            services.AddScoped<ICountryService, CountryManager>();
            services.AddScoped<ICourseCategoryService, CourseCategoryManager>();
            services.AddScoped<ICourseContentService, CourseContentManager>();
            services.AddScoped<ICourseContentTypeService, CourseContentTypeManager>();
            services.AddScoped<ICourseDetailService, CourseDetailManager>();
            services.AddScoped<ICourseService, CourseManager>();
            services.AddScoped<IDistrictService, DistrictManager>();
            services.AddScoped<IEducationProgramService, EducationProgramManager>();
            services.AddScoped<IEducationStatusService, EducationStatusManager>();
            services.AddScoped<IExperienceService, ExperienceManager>();
            services.AddScoped<IForeignLanguageLevelService, ForeignLanguageLevelManager>();
            services.AddScoped<IForeignLanguageService, ForeignLanguageManager>();
            services.AddScoped<ILessonService, LessonManager>();
            services.AddScoped<ILessonStatusService, LessonStatusManager>();
            services.AddScoped<IMembershipStatusService, MembershipStatusManager>();
            services.AddScoped<IOrganizationService, OrganizationManager>();
            services.AddScoped<IProfileImageService, ProfileImageManager>();
            services.AddScoped<IQuestionService, QuestionManager>();
            services.AddScoped<IQuestionCategoryService, QuestionCategoryManager>();
            services.AddScoped<ISessionStatusService, SessionStatusManager>();
            services.AddScoped<ISkillService, SkillManager>();
            services.AddScoped<ISocialMediaPlatformService, SocialMediaPlatformManager>();
            services.AddScoped<ISubLectureService, SubLectureManager>();
            services.AddScoped<ISurveyService, SurveyManager>();
            services.AddScoped<ISurveyTypeService, SurveyTypeManager>();
            services.AddScoped<ITokenHelper, JwtHelper>();
            services.AddScoped<IUniversityService, UniversityManager>();
            services.AddScoped<IUserService, UserManager>();

            // ----------------------FOR RULES-----------------------
            services.AddScoped<AccountApplicationBusinessRules>();
            services.AddScoped<AccountCertificateBusinessRules>();
            services.AddScoped<AccountCourseBusinessRules>();
            services.AddScoped<AccountCourseLessonBusinessRules>();
            services.AddScoped<AccountEducationBusinessRules>();
            services.AddScoped<AccountSocialMediaBusinessRules>();
            services.AddScoped<CityBusinessRules>();
            services.AddScoped<CountryBusinessRules>();
            services.AddScoped<CourseBusinessRules>();
            services.AddScoped<CourseCategoryBusinessRules>();
            services.AddScoped<CourseContentBusinessRules>();
            services.AddScoped<CourseContentTypeBusinessRules>();
            services.AddScoped<CourseDetailBusinessRules>();
            services.AddScoped<EducationProgramBusinessRules>();
            services.AddScoped<ExperienceBusinessRules>();
            services.AddScoped<LessonBusinessRules>();
            services.AddScoped<LessonStatusBusinessRules>();
            services.AddScoped<OrganizationBusinessRules>();
            services.AddScoped<SocialMediaPlatformBusinessRules>();
            services.AddScoped<UniversityBusinessRules>();
            services.AddScoped<AccountBusinessRules>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
