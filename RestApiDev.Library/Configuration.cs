using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestApiDev.Library.Mapping;

namespace RestApiDev.Library
{
    public static class Configuration
    {
        public static IConfigurationBuilder ConfigurationBuilder { get; set; } = new ConfigurationBuilder();

        public static IConfigurationRoot ConfigurationRoot { get; set; } = BuildConfiguration(ConfigurationBuilder);

        public static IConfigurationRoot BuildConfiguration(IConfigurationBuilder builder)
        {
            return builder
                    .AddEnvironmentVariables()
                    //.AddKeyVaultSecrets()
                    .Build();
        }

        public static IServiceCollection ConfigureServiceCollection(IServiceCollection collection)
        {
            return collection
                .AddSingleton<IConfiguration>(ConfigurationRoot)
                .AddSingleton(typeof(IMapper), AutoMappingRegister.Create());
        }
    }
}
