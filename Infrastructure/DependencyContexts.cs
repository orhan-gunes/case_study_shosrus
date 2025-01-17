﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace shopsruscase.Infrastructure
{
  public static  class DependencyContexts
    {
        public static IServiceCollection AddInfrastructures(this IServiceCollection services, IConfiguration config) 
        {
          
            return services;
        
        }
        public static void SetSqlServerOptions(this DbContextOptionsBuilder builder, IConfiguration conf)
        {
            string connectionString = conf[$"ConnectionStrings:Default"];
            builder.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString));
        
        }

   
    }
}
