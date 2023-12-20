using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DataAccessServiceRegistration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {


            services.AddDbContext<TobetoContext>(options => options.UseSqlServer(configuration.GetConnectionString("Tobeto")));
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<ILanguageDal, EfLanguageDal>();


            services.AddScoped<IExperienceDal, EfExperienceDal>();
            services.AddScoped<IEducationDal, EfEducationDal>();
            services.AddScoped<IPersonalInformationDal, EfPersonalInformationDal>();
            //services.AddScoped<ISkillsDal, EfSkillsDal>();

            //services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            //services.AddScoped<IExperienceDal, EfExperienceDal>();
            //services.AddScoped<IEducationDal, EfEducationDal>();

            services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
            services.AddScoped<ICertificateDal, EfCertificateDal>();
            services.AddScoped<IProfileImageDal, EfProfileImageDal>();
            services.AddScoped<IUserDal, EfUserDal>();
            services.AddScoped<IAccountDal, EfAccountDal>();
            services.AddScoped<IForeignLanguageDal, EfForeignLanguageDal>();
            services.AddScoped<IForeignLanguageLevelDal, EfForeignLanguageLevelDal>();
            services.AddScoped<IAccountForeignLanguageDal, EfAccountForeignLanguageDal>();
            services.AddScoped<ICourseCategoryDal, EfCourseCategoryDal>();
            services.AddScoped<ICourseContentTypeDal, EfCourseContentTypeDal>();
            services.AddScoped<ICourseContentDal, EfCourseContentDal>();
            services.AddScoped<ILessonDal, EfLessonDal>();
            services.AddScoped<ICourseDal, EfCourseDal>();
            services.AddScoped<ICourseDetailDal, EfCourseDetailDal>();
            services.AddScoped<IAccountCourseDal, EfAccountCourseDal>();
            services.AddScoped<IAccountCourseLessonDal, EfAccountCourseLessonDal>();


            //services.AddScoped<IPlatformCatalogDal,EfPlatformCatalogDal>();

            return services;
        }
    }
}
