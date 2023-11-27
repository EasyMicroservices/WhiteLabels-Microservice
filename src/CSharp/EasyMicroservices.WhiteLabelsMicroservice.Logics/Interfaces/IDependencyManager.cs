using EasyMicroservices.Database.Interfaces;
using EasyMicroservices.Mapper.Interfaces;

namespace EasyMicroservices.WhiteLabelsMicroservice.Interfaces
{
    public interface IDependencyManager
    {
        IDatabase GetDatabase();
        IMapperProvider GetMapper();
    }
}
