using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common;
using EasyMicroservices.WhiteLabelsMicroservice.Database.Entities;

namespace EasyMicroservices.WhiteLabelsMicroservice.WebApi.Controllers
{
    public class ContextTableController : SimpleQueryServiceController<ContextTableEntity, ContextTableContract, ContextTableContract, ContextTableContract, long>
    {
        public ContextTableController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}