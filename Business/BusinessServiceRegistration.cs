using Business.Abstract;
using Business.Concrete;
<<<<<<< Updated upstream
using Core.Security.JWT;
=======
using Business.Rules;
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            services.AddScoped<ILanguageService, LanguageManager>();
<<<<<<< Updated upstream
            services.AddScoped<ISkillsService, SkillsManager>();
=======
            
            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IEducationService, EducationManager>();
            services.AddScoped<IExperienceService, ExperienceManager>();
           
>>>>>>> Stashed changes
            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<IPlatformCatalogService, PlatformCatalogManager>();
=======
>>>>>>> Stashed changes
            services.AddScoped<ICertificateService, CertificateManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IAuthService, AuthManager>();
            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IForeignLanguageService, ForeignLanguageManager>();    
            services.AddScoped<ITokenHelper,JwtHelper>();



            // services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<ISkillsService, SkillsManager>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();

            services.AddScoped<IPlatformCatalogService, PlatformCatalogManager>();

            services.AddScoped<CertificateBusinessRules>();

            //  services.AddScoped<IEducationService, EducationManager>();
            //  services.AddScoped<IExperienceService, ExperienceManager>();

            // services.AddScoped<IPersonalInformationService, PersonalInformationManager>();

            // services.AddAutoMapper(typeof(BusinessServiceRegistration));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;

        }

    }
}
