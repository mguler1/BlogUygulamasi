using BlogUygulaması.Business.Concrete;
using BlogUygulaması.Business.Interfaces;
using BlogUygulaması.Business.Tools.JWTTool;
using BlogUygulaması.Business.ValidationRules.FluentValidation;
using BlogUygulaması.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using BlogUygulaması.DataAccess.Interfaces;
using BlogUygulaması.Dto.DTOs.AppUserDto;
using BlogUygulaması.Dto.DTOs.CategoryBlogDtos;
using BlogUygulaması.Dto.DTOs.CategoryDto;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogUygulaması.Business.Containers.MicrosoftIoC
{
   public static class CustomExtension
    {
        public static void AddDependencies(this IServiceCollection services )
        {
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IBlogService,BlogManager>();
            services.AddScoped<IBlogDal,EfBlogRepository>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryRepository>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();

            services.AddScoped<IJwtService, JwtManager>();

            services.AddTransient<IValidator<LogInDto>, AppUserLoginValidator>();
            services.AddTransient<IValidator<CategoryAddDto>, CategoryAddValidator>();
            services.AddTransient<IValidator<CategoryUpdateDto>, CategoryUpdateValidator>();
            services.AddTransient<IValidator<CategoryBlogDto>, CategoryBlogValidator>();
          
        }
    }
}
