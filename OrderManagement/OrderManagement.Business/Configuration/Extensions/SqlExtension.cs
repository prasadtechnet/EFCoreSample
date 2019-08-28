using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrderManagement.DataInfrastructure.ContextCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Business.Configuration.Extensions
{
   public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddSqlServer(this IServiceCollection services,string connection)
        {
            services.AddDbContext<DataContext>(opt=>opt.UseSqlServer(connection));
            return services;
        }       
    }

    public static class IApplicationBuilderExtension
    {
        public static IApplicationBuilder UseAppBuilder(this IApplicationBuilder appBuilder)
        {
            
            return appBuilder;
        }
    }
}
