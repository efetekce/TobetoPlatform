using Business.Abstract;
using Business.Concrete;
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
            services.AddScoped<ILanguageService, LanguageManager>();
            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IExperienceService, ExperienceManager>();
            services.AddScoped<IPersonalInformationService, PersonalInformationManager>();
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

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
