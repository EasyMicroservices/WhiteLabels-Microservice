using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common;
using EasyMicroservices.WhiteLabelsMicroservice.Database.Entities;

namespace EasyMicroservices.WhiteLabelsMicroservice.WebApi.Controllers
{
    public class WhiteLabelController : SimpleQueryServiceController<WhiteLabelEntity, WhiteLabelContract, WhiteLabelContract, WhiteLabelContract, long>
    {
        public WhiteLabelController(IContractLogic<WhiteLabelEntity, WhiteLabelContract, WhiteLabelContract, WhiteLabelContract, long> contractReadable) : base(contractReadable)
        {

        }
    }
}