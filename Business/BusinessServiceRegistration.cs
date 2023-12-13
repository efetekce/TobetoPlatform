﻿using Business.Abstract;
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

            services.AddScoped<IEducationService, EducationManager>();
            services.AddScoped<IExperienceService, ExperienceManager>();

            services.AddScoped<IPersonalInformationService, PersonalInformationManager>();
            services.AddScoped<ISkillsService, SkillsManager>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();

           
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;

        }

    }
}
