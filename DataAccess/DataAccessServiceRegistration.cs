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
            
            services.AddScoped<IAssessmentDal, EfAssessmentDal>();
            services.AddScoped<IQuestionCategoryDal, EfQuestionCategoryDal>();
            services.AddScoped<IQuestionDal, EfQuestionDal>();
            services.AddScoped<IAnswerDal, EfAnswerDal>();
            services.AddScoped<IMembershipStatusDal, EfMembershipStatusDal>();
            //services.AddScoped<IAccountPasswordDal, EfAccountPasswordDal>();
            services.AddScoped<ISessionStatusDal, EfSessionStatusDal>();
            services.AddScoped<IOrganizationDal, EfOrganizationDal>();
            services.AddScoped<ISurveyDal, EfSurveyDal>();
            services.AddScoped<ISurveyTypeDal, EfSurveyTypeDal>();
            services.AddScoped<IApplicationDal, EfApplicationDal>();
            services.AddScoped<IAccountApplicationDal, EfAccountApplicationDal>();
            services.AddScoped<IApplicationStepDal, EfApplicationStepDal>();
            services.AddScoped<IUserDal, EfUserDal>();            
            services.AddScoped<ICourseCategoryDal, EfCourseCategoryDal>();
            services.AddScoped<ICourseContentTypeDal, EfCourseContentTypeDal>();
            services.AddScoped<ICourseContentDal, EfCourseContentDal>();
            services.AddScoped<ILessonDal, EfLessonDal>();
            services.AddScoped<ILessonStatusDal, EfLessonStatusDal>();
            services.AddScoped<ICourseDal, EfCourseDal>();
            services.AddScoped<ICourseDetailDal, EfCourseDetailDal>();
            services.AddScoped<IAccountCourseDal, EfAccountCourseDal>();
            services.AddScoped<IAccountCourseLessonDal, EfAccountCourseLessonDal>();

            //Profil sayfasına ait dal bilgileri...
            services.AddScoped<IAccountDal, EfAccountDal>();
            services.AddScoped<IProfileImageDal, EfProfileImageDal>();
            services.AddScoped<ICountryDal, EfCountryDal>();
            services.AddScoped<ICityDal, EfCityDal>();
            services.AddScoped<IDistrictDal, EfDistrictDal>();
            services.AddScoped<IAccountExperienceDal, EfAccountExperienceDal>();
            services.AddScoped<IAccountEducationDal, EfAccountEducationDal>();
            services.AddScoped<IEducationStatusDal, EfEducationStatusDal>();
            services.AddScoped<IUniversityDal, EfUniversityDal>();
            services.AddScoped<IEducationProgramDal, EfEducationProgramDal>();
            services.AddScoped<IAccountSkillDal, EfAccountSkillDal>();
            services.AddScoped<ISkillDal, EfSkillDal>();
            services.AddScoped<IAccountCertificateDal, EfAccountCertificateDal>();
            services.AddScoped<IAccountSocialMediaDal, EfAccountSocialMediaDal>();
            services.AddScoped<ISocialMediaPlatformDal, EfSocialMediaPlatformDal>();
            services.AddScoped<IAccountForeignLanguageDal, EfAccountForeignLanguageDal>();
            services.AddScoped<IForeignLanguageDal, EfForeignLanguageDal>();
            services.AddScoped<IForeignLanguageLevelDal, EfForeignLanguageLevelDal>();




            
            
            

            return services;
        }
    }
}
