using Business.Abstract;
using Business.Concrete;
using Core.Security.JWT;
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
            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IExperienceService, ExperienceManager>();
            services.AddScoped<IPersonalInformationService, PersonalInformationManager>();
            services.AddScoped<IAddressService, AddressManager>();
            services.AddScoped<ICountryService, CountryManager>();
            services.AddScoped<ICityService, CityManager>();
            services.AddScoped<IDistrictService, DistrictManager>();
            services.AddScoped<IAssessmentService, AssessmentManager>();
            services.AddScoped<IQuestionCategoryService, QuestionCategoryManager>();
            services.AddScoped<IQuestionService, QuestionManager>();
            services.AddScoped<IAnswerService, AnswerManager>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<ICertificateService, CertificateManager>();
            services.AddScoped<IMembershipStatusService, MembershipStatusManager>();
            services.AddScoped<ISessionStatusService, SessionStatusManager>();
            services.AddScoped<IAccountPasswordService, AccountPasswordManager>();
            services.AddScoped<ISocialMediaPlatformService, SocialMediaPlatformManager>();
            services.AddScoped<IAccountSocialMediaService, AccountSocialMediaManager>();
            services.AddScoped<IEducationStatusService, EducationStatusManager>();
            services.AddScoped<IUniversityService, UniversityManager>();
            services.AddScoped<IAccountEducationService, AccountEducationManager>();
            services.AddScoped<IEducationProgramService, EducationProgramManager>();
            services.AddScoped<IOrganizationService, OrganizationManager>();
            services.AddScoped<ISurveyService, SurveyManager>();
            services.AddScoped<ISurveyTypeService, SurveyTypeManager>();
            services.AddScoped<IApplicationService, ApplicationManager>();
            services.AddScoped<IAccountApplicationService, AccountApplicationManager>();
            services.AddScoped<IApplicationStepService, ApplicationStepManager>();
            services.AddScoped<ISkillService, SkillManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IAuthService, AuthManager>();
            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IForeignLanguageService, ForeignLanguageManager>();
            services.AddScoped<ITokenHelper, JwtHelper>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
