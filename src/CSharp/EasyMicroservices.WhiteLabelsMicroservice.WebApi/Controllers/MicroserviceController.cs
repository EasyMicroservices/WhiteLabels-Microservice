using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common;
using EasyMicroservices.WhiteLabelsMicroservice.Database.Entities;

namespace EasyMicroservices.WhiteLabelsMicroservice.WebApi.Controllers
{
    public class MicroserviceController : SimpleQueryServiceController<MicroserviceEntity, MicroserviceContract, MicroserviceContract, MicroserviceContract, long>
    {
        public MicroserviceController(IContractLogic<MicroserviceEntity, MicroserviceContract, MicroserviceContract, MicroserviceContract, long> contractReadable) : base(contractReadable)
        {

        }
    }
}
