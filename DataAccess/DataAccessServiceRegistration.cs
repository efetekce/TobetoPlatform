using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
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
            services.AddDbContext<TobetoContext>(options =>
                options
                    .UseSqlServer(configuration.GetConnectionString("Tobeto")));
            services.AddScoped<IAccountDal, EfAccountDal>();
            services.AddScoped<IAccountApplicationDal, EfAccountApplicationDal>();
            services.AddScoped<IAccountCertificateDal, EfAccountCertificateDal>();
            services.AddScoped<IAccountCourseDal, EfAccountCourseDal>();
            services.AddScoped<IAccountCourseLessonDal, EfAccountCourseLessonDal>();
            services.AddScoped<IAccountEducationDal, EfAccountEducationDal>();
            services.AddScoped<IAccountForeignLanguageDal, EfAccountForeignLanguageDal>();
            services.AddScoped<IAccountSkillDal, EfAccountSkillDal>();
            services.AddScoped<IAccountSocialMediaDal, EfAccountSocialMediaDal>();
            services.AddScoped<IAccountTestResultDal, EfAccountTestResultDal>();
            services.AddScoped<IAddressDal, EfAddressDal>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IAnnouncementTypeDal, EfAnnouncementTypeDal>();
            services.AddScoped<IAnswerDal, EfAnswerDal>();
            services.AddScoped<IApplicationDal, EfApplicationDal>();
            services.AddScoped<IApplicationStepDal, EfApplicationStepDal>();
            services.AddScoped<IAssessmentDal, EfAssessmentDal>();
            services.AddScoped<ICityDal, EfCityDal>();
            services.AddScoped<ICountryDal, EfCountryDal>();
            services.AddScoped<ICourseDal, EfCourseDal>();
            services.AddScoped<ICourseCategoryDal, EfCourseCategoryDal>();
            services.AddScoped<ICourseContentDal, EfCourseContentDal>();
            services.AddScoped<ICourseContentTypeDal, EfCourseContentTypeDal>();
            services.AddScoped<ICourseDetailDal, EfCourseDetailDal>();
            services.AddScoped<IDistrictDal, EfDistrictDal>();
            services.AddScoped<IEducationProgramDal, EfEducationProgramDal>();
            services.AddScoped<IEducationStatusDal, EfEducationStatusDal>();
            services.AddScoped<IExperienceDal, EfExperienceDal>();
            services.AddScoped<IForeignLanguageDal, EfForeignLanguageDal>();
            services.AddScoped<IForeignLanguageLevelDal, EfForeignLanguageLevelDal>();
            services.AddScoped<ILessonDal, EfLessonDal>();
            services.AddScoped<ILessonStatusDal, EfLessonStatusDal>();
            services.AddScoped<IMembershipStatusDal, EfMembershipStatusDal>();
            services.AddScoped<IOrganizationDal, EfOrganizationDal>();
            services.AddScoped<IProfileImageDal, EfProfileImageDal>();
            services.AddScoped<IQuestionDal, EfQuestionDal>();
            services.AddScoped<IQuestionCategoryDal, EfQuestionCategoryDal>();
            services.AddScoped<ISessionStatusDal, EfSessionStatusDal>();
            services.AddScoped<ISkillDal, EfSkillDal>();
            services.AddScoped<ISocialMediaPlatformDal, EfSocialMediaPlatformDal>();
            services.AddScoped<ISubLectureDal, EfSubLectureDal>();
            services.AddScoped<ISurveyDal, EfSurveyDal>();
            services.AddScoped<ISurveyTypeDal, EfSurveyTypeDal>();
            services.AddScoped<IUniversityDal, EfUniversityDal>();
            services.AddScoped<IUserDal, EfUserDal>();

            return services;
        }
    }
}
