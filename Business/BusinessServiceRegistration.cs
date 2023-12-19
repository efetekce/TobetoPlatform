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
            services.AddScoped<IEducationService, EducationManager>();
            services.AddScoped<IExperienceService, ExperienceManager>();
           

                  

            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<ICertificateService, CertificateManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IAuthService, AuthManager>();
            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IForeignLanguageService, ForeignLanguageManager>();    
            services.AddScoped<ITokenHelper,JwtHelper>();


            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
