namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            MapperConfiguration mapperConfig = new MapperConfiguration(
        cfg =>
        {
            cfg.AddProfile(new OrderMappingProfile());
        });

            IMapper mapper = new Mapper(mapperConfig);

            mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }
    }
}