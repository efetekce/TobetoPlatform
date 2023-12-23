using Business.Abstract;
using Business.Concrete;
using Business.Rules;
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
            services.AddScoped<IAccountApplicationService, AccountApplicationManager>();
            services.AddScoped<IAccountCertificateService, AccountCertificateManager>();
            services.AddScoped<IAccountCourseLessonService, AccountCourseLessonManager>();
            services.AddScoped<IAccountCourseService, AccountCourseManager>();
            services.AddScoped<IAccountEducationService, AccountEducationManager>();
            services.AddScoped<IAccountForeignLanguageService, AccountForeignLanguageManager>();
            services.AddScoped<IAccountPasswordService, AccountPasswordManager>();
            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnswerService, AnswerManager>();
            services.AddScoped<IApplicationService, ApplicationManager>();
            services.AddScoped<IApplicationStepService, ApplicationStepManager>();
            services.AddScoped<IAuthService, AuthManager>();
            services.AddScoped<ICityService, CityManager>();
            services.AddScoped<ICountryService, CountryManager>();
            services.AddScoped<ICourseCategoryService, CourseCategoryManager>();
            services.AddScoped<ICourseContentService, CourseContentManager>();
            services.AddScoped<ICourseContentTypeService, CourseContentTypeManager>();
            services.AddScoped<ICourseDetailService, CourseDetailManager>();
            services.AddScoped<ICourseService, CourseManager>();
            services.AddScoped<IEducationProgramService, EducationProgramManager>();
            services.AddScoped<IEducationStatusService, EducationStatusManager>();
            services.AddScoped<IExperienceService, ExperienceManager>();
            services.AddScoped<IForeignLanguageLevelService, ForeignLanguageLevelManager>();
            services.AddScoped<IForeignLanguageService, ForeignLanguageManager>();
            services.AddScoped<ILessonService, LessonManager>();
            services.AddScoped<ILessonStatusService, LessonStatusManager>();
            services.AddScoped<IMembershipStatusService, MembershipStatusManager>();
            services.AddScoped<IOrganizationService, OrganizationManager>();
            services.AddScoped<IQuestionCategoryService, QuestionCategoryManager>();
            services.AddScoped<IQuestionService, QuestionManager>();
            services.AddScoped<ISessionStatusService, SessionStatusManager>();
            services.AddScoped<ISkillService, SkillManager>();
            services.AddScoped<ISocialMediaPlatformService, SocialMediaPlatformManager>();
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

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
