using Business.Abstract;
using Business.Concrete;
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

            

            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAddressService, AddressManager>();
            services.AddScoped<ICountryService, CountryManager>();
            services.AddScoped<ICityService, CityManager>();
            services.AddScoped<IDistrictService, DistrictManager>();
            services.AddScoped<IEducationService, EducationManager>();
            services.AddScoped<IExperienceService, ExperienceManager>();

            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<ICertificateService, CertificateManager>();
            services.AddScoped<ISkillService, SkillManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IAuthService, AuthManager>();
            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IForeignLanguageService, ForeignLanguageManager>();    
            services.AddScoped<ITokenHelper,JwtHelper>();
            services.AddScoped<IForeignLanguageLevelService,ForeignLanguageLevelManager>();
            services.AddScoped<IAccountForeignLanguageService,AccountForeignLanguageManager>();
            services.AddScoped<ICourseCategoryService,CourseCategoryManager>();
            services.AddScoped<ICourseContentTypeService,CourseContentTypeManager>();
            services.AddScoped<ICourseContentService,CourseContentManager>();
            services.AddScoped<ILessonService, LessonManager>();
            services.AddScoped<ICourseService, CourseManager>();
            services.AddScoped<IAccountCourseLessonService, AccountCourseLessonManager>();
            

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
