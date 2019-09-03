using AutoMapper;

namespace RestApiDev.Library.Mapping
{
    public static class AutoMappingRegister
    {
        public static IMapper Create()
        {
            var builder = new MapperConfiguration(RegisterMappings);
            builder.AssertConfigurationIsValid();

            return builder.CreateMapper();
        }

        private static void RegisterMappings(IMapperConfigurationExpression config)
        {
            config.AddProfile<ToPromotion>();
        }
    }
}
