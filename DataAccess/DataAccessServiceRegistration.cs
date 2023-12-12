﻿using DataAccess.Abstracts;
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
            //  services.AddDbContext<NorthwindContext>(options => options.UseInMemoryDatabase("nArchitecture"));



            services.AddDbContext<TobetoContext>(options => options.UseSqlServer(configuration.GetConnectionString("Tobeto")));
            services.AddScoped<ILanguageDal, EfLanguageDal>();
            services.AddScoped<IPersonalInformationDal, EfPersonalInformationDal>();

            //services.AddScoped<ICategoryDal, EfCategoryDal>();
            //services.AddScoped<ICourseDal, EfCourseDal>();
            return services;
        }
    }
}
