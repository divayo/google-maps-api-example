using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleMapsApiExample.Common.Extensions
{
    public static class ConfigurationExtension
    {
        // Add configuration section as singleton for dependency injection
        public static void AddConfiguration<T>(
            this IServiceCollection services,
            IConfiguration configuration,
            string configurationSectionName = null)
            where T : class
        {
            if (string.IsNullOrEmpty(configurationSectionName))
            {
                configurationSectionName = typeof(T).Name;
            }

            var instance = Activator.CreateInstance<T>();
            new ConfigureFromConfigurationOptions<T>(configuration.GetSection(configurationSectionName)).Configure(instance);
            services.AddSingleton(instance);
        }
    }
}
