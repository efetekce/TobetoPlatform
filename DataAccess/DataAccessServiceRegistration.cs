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
<<<<<<< Updated upstream
            services.AddDbContext<TobetoContext>(options => options.UseSqlServer(configuration.GetConnectionString("Tobeto")));
            services.AddScoped<ILanguageDal, EfLanguageDal>();

            services.AddScoped<ISkillsDal, EfSkillsDal>();
=======
            services.AddDbContext<TobetoContext>(options => options.UseSqlServer(configuration.GetConnectionString("TobetoPlatformContext")));

            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            
            services.AddScoped<IExperienceDal, EfExperienceDal>();
            services.AddScoped<IEducationDal, EfEducationDal>();
          
>>>>>>> Stashed changes
            services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
<<<<<<< Updated upstream
            services.AddScoped<ICertificateDal, EfCertificateDal>();
=======
            services.AddScoped<IProfileImageDal, EfProfileImageDal>();
            services.AddScoped<IUserDal, EfUserDal>();
            services.AddScoped<IAccountDal, EfAccountDal>();
            services.AddScoped<IForeignLanguageDal, EfForeignLanguageDal>();



            //services.AddScoped<ICategoryDal, EfCategoryDal>();
            //services.AddScoped<ICourseDal, EfCourseDal>();

>>>>>>> Stashed changes
            services.AddScoped<IPlatformCatalogDal,EfPlatformCatalogDal>();

            return services;
        }
    }
}
