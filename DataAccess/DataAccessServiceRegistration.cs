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
            services.AddScoped<IAddressDal, EfAddressDal>();
            services.AddScoped<ICountryDal, EfCountryDal>();
            services.AddScoped<ICityDal, EfCityDal>();
            services.AddScoped<IDistrictDal, EfDistrictDal>();
            services.AddScoped<ILanguageDal, EfLanguageDal>();
            services.AddScoped<IPersonalInformationDal, EfPersonalInformationDal>();
            services.AddScoped<IExperienceDal, EfExperienceDal>();
            services.AddScoped<IPersonalInformationDal, EfPersonalInformationDal>();
            services.AddScoped<IAssessmentDal, EfAssessmentDal>();
            services.AddScoped<IQuestionCategoryDal, EfQuestionCategoryDal>();
            services.AddScoped<IQuestionDal, EfQuestionDal>();
            services.AddScoped<IAnswerDal, EfAnswerDal>();
            services.AddScoped<ICertificateDal, EfCertificateDal>();
            services.AddScoped<IProfileImageDal, EfProfileImageDal>();
            services.AddScoped<IMembershipStatusDal, EfMembershipStatusDal>();
            services.AddScoped<IAccountPasswordDal, EfAccountPasswordDal>();
            services.AddScoped<ISessionStatusDal, EfSessionStatusDal>();
            services.AddScoped<ISocialMediaPlatformDal, EfSocialMediaPlatformDal>();
            services.AddScoped<IAccountSocialMediaDal, EfAccountSocialMediaDal>();
            services.AddScoped<IEducationStatusDal, EfEducationStatusDal>();
            services.AddScoped<IUniversityDal, EfUniversityDal>();
            services.AddScoped<IEducationProgramDal, EfEducationProgramDal>();
            services.AddScoped<IAccountEducationDal, EfAccountEducationDal>();
            services.AddScoped<IOrganizationDal, EfOrganizationDal>();
            services.AddScoped<ISurveyDal, EfSurveyDal>();
            services.AddScoped<ISurveyTypeDal, EfSurveyTypeDal>();
            services.AddScoped<IApplicationDal, EfApplicationDal>();
            services.AddScoped<IAccountApplicationDal, EfAccountApplicationDal>();
            services.AddScoped<IApplicationStepDal, EfApplicationStepDal>();
            services.AddScoped<ISkillDal, EfSkillDal>();
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
            //services.AddScoped<ISkillsDal, EfSkillsDal>();
            //services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();

            return services;
        }
    }
}
