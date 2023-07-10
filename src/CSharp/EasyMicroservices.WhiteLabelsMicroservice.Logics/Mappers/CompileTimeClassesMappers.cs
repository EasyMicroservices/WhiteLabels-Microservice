using System.Threading.Tasks;
using EasyMicroservices.Mapper.CompileTimeMapper.Interfaces;
using EasyMicroservices.Mapper.Interfaces;
using System.Linq;

namespace CompileTimeMapper
{
    public class MicroserviceContextTableEntity_MicroserviceContextTableContract_Mapper : IMapper
    {
        readonly IMapperProvider _mapper;
        public MicroserviceContextTableEntity_MicroserviceContextTableContract_Mapper(IMapperProvider mapper)
        {
            _mapper = mapper;
        }

        public global::EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.MicroserviceContextTableEntity Map(global::EasyMicroservices.WhiteLabelsMicroservice.Contracts.Responses.MicroserviceContextTableContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.MicroserviceContextTableEntity()
            {
                ContextTableId = fromObject.ContextTableId,
                MicroserviceId = fromObject.MicroserviceId,
            };
            return mapped;
        }

        public global::EasyMicroservices.WhiteLabelsMicroservice.Contracts.Responses.MicroserviceContextTableContract Map(global::EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.MicroserviceContextTableEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.WhiteLabelsMicroservice.Contracts.Responses.MicroserviceContextTableContract()
            {
                ContextName = fromObject.ContextTable?.ContextName,
                ContextTableId = fromObject.ContextTableId,
                MicroserviceId = fromObject.MicroserviceId,
                MicroserviceName = fromObject.Microservice?.Name,
                TableName = fromObject.ContextTable?.TableName,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.MicroserviceContextTableEntity> MapAsync(global::EasyMicroservices.WhiteLabelsMicroservice.Contracts.Responses.MicroserviceContextTableContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.MicroserviceContextTableEntity()
            {
                ContextTableId = fromObject.ContextTableId,
                MicroserviceId = fromObject.MicroserviceId,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.WhiteLabelsMicroservice.Contracts.Responses.MicroserviceContextTableContract> MapAsync(global::EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.MicroserviceContextTableEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.WhiteLabelsMicroservice.Contracts.Responses.MicroserviceContextTableContract()
            {
                ContextName = fromObject.ContextTable?.ContextName,
                ContextTableId = fromObject.ContextTableId,
                MicroserviceId = fromObject.MicroserviceId,
                MicroserviceName = fromObject.Microservice?.Name,
                TableName = fromObject.ContextTable?.TableName,
            };
            return mapped;
        }
        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.MicroserviceContextTableEntity))
                return Map((EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.MicroserviceContextTableEntity)fromObject, uniqueRecordId, language, parameters);
            return Map((EasyMicroservices.WhiteLabelsMicroservice.Contracts.Responses.MicroserviceContextTableContract)fromObject, uniqueRecordId, language, parameters);
        }
        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.MicroserviceContextTableEntity))
                return await MapAsync((EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.MicroserviceContextTableEntity)fromObject, uniqueRecordId, language, parameters);
            return await MapAsync((EasyMicroservices.WhiteLabelsMicroservice.Contracts.Responses.MicroserviceContextTableContract)fromObject, uniqueRecordId, language, parameters);
        }
    }
    public class MicroserviceEntity_MicroserviceContract_Mapper : IMapper
    {
        readonly IMapperProvider _mapper;
        public MicroserviceEntity_MicroserviceContract_Mapper(IMapperProvider mapper)
        {
            _mapper = mapper;
        }

        public global::EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.MicroserviceEntity Map(global::EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common.MicroserviceContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.MicroserviceEntity()
            {
                Description = fromObject.Description,
                Id = fromObject.Id,
                InstanceIndex = fromObject.InstanceIndex,
                Name = fromObject.Name,
                ServerDestinationAddress = fromObject.ServerDestinationAddress,
            };
            return mapped;
        }

        public global::EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common.MicroserviceContract Map(global::EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.MicroserviceEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common.MicroserviceContract()
            {
                Description = fromObject.Description,
                Id = fromObject.Id,
                InstanceIndex = fromObject.InstanceIndex,
                Name = fromObject.Name,
                ServerDestinationAddress = fromObject.ServerDestinationAddress,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.MicroserviceEntity> MapAsync(global::EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common.MicroserviceContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.MicroserviceEntity()
            {
                Description = fromObject.Description,
                Id = fromObject.Id,
                InstanceIndex = fromObject.InstanceIndex,
                Name = fromObject.Name,
                ServerDestinationAddress = fromObject.ServerDestinationAddress,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common.MicroserviceContract> MapAsync(global::EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.MicroserviceEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common.MicroserviceContract()
            {
                Description = fromObject.Description,
                Id = fromObject.Id,
                InstanceIndex = fromObject.InstanceIndex,
                Name = fromObject.Name,
                ServerDestinationAddress = fromObject.ServerDestinationAddress,
            };
            return mapped;
        }
        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.MicroserviceEntity))
                return Map((EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.MicroserviceEntity)fromObject, uniqueRecordId, language, parameters);
            return Map((EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common.MicroserviceContract)fromObject, uniqueRecordId, language, parameters);
        }
        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.MicroserviceEntity))
                return await MapAsync((EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.MicroserviceEntity)fromObject, uniqueRecordId, language, parameters);
            return await MapAsync((EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common.MicroserviceContract)fromObject, uniqueRecordId, language, parameters);
        }
    }
    public class WhiteLabelEntity_WhiteLabelContract_Mapper : IMapper
    {
        readonly IMapperProvider _mapper;
        public WhiteLabelEntity_WhiteLabelContract_Mapper(IMapperProvider mapper)
        {
            _mapper = mapper;
        }

        public global::EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.WhiteLabelEntity Map(global::EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common.WhiteLabelContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.WhiteLabelEntity()
            {
                Description = fromObject.Description,
                Id = fromObject.Id,
                Name = fromObject.Name,
                ParentId = fromObject.ParentId,
            };
            return mapped;
        }

        public global::EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common.WhiteLabelContract Map(global::EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.WhiteLabelEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common.WhiteLabelContract()
            {
                Description = fromObject.Description,
                Id = fromObject.Id,
                Name = fromObject.Name,
                ParentId = fromObject.ParentId,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.WhiteLabelEntity> MapAsync(global::EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common.WhiteLabelContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.WhiteLabelEntity()
            {
                Description = fromObject.Description,
                Id = fromObject.Id,
                Name = fromObject.Name,
                ParentId = fromObject.ParentId,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common.WhiteLabelContract> MapAsync(global::EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.WhiteLabelEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common.WhiteLabelContract()
            {
                Description = fromObject.Description,
                Id = fromObject.Id,
                Name = fromObject.Name,
                ParentId = fromObject.ParentId,
            };
            return mapped;
        }
        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.WhiteLabelEntity))
                return Map((EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.WhiteLabelEntity)fromObject, uniqueRecordId, language, parameters);
            return Map((EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common.WhiteLabelContract)fromObject, uniqueRecordId, language, parameters);
        }
        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.WhiteLabelEntity))
                return await MapAsync((EasyMicroservices.WhiteLabelsMicroservice.Database.Entities.WhiteLabelEntity)fromObject, uniqueRecordId, language, parameters);
            return await MapAsync((EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common.WhiteLabelContract)fromObject, uniqueRecordId, language, parameters);
        }
    }
}