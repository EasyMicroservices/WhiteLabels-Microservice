using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common;
using EasyMicroservices.WhiteLabelsMicroservice.Database.Entities;

namespace EasyMicroservices.WhiteLabelsMicroservice.WebApi.Controllers
{
    public class ContextTableController : SimpleQueryServiceController<ContextTableEntity, ContextTableContract, ContextTableContract, ContextTableContract, long>
    {
        public ContextTableController(IContractLogic<ContextTableEntity, ContextTableContract, ContextTableContract, ContextTableContract, long> contractReadable) : base(contractReadable)
        {

        }
    }
}