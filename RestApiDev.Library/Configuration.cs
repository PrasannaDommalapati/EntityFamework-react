using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using RestApiDev.Library.Mapping;

namespace RestApiDev.Library
{
    public static class Configuration
    {
        public static IServiceCollection ConfigureServiceCollection(IServiceCollection collection)
        {
            return collection
                    .AddSingleton(typeof(IMapper), AutoMappingRegister.Create());
        }
    }
}
