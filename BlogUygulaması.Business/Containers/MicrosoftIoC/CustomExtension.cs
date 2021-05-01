using BlogUygulaması.Business.Concrete;
using BlogUygulaması.Business.Interfaces;
using BlogUygulaması.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using BlogUygulaması.DataAccess.Interfaces;
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
        }
    }
}
