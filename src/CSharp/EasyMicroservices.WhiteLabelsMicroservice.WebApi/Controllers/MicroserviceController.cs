using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common;
using EasyMicroservices.WhiteLabelsMicroservice.Database.Entities;

namespace EasyMicroservices.WhiteLabelsMicroservice.WebApi.Controllers
{
    public class MicroserviceController : SimpleQueryServiceController<MicroserviceEntity, MicroserviceContract, MicroserviceContract, MicroserviceContract, long>
    {
        public MicroserviceController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
