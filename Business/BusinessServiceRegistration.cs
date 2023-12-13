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
            services.AddScoped<ISkillsService, SkillsManager>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<IPlatformCatalogService, PlatformCatalogManager>();
            services.AddScoped<ICertificateService, CertificateManager>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;

        }

    }
}
