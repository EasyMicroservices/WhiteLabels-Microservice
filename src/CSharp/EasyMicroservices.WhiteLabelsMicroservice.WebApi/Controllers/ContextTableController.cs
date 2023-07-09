using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.WhiteLabelsMicroservice.Contracts.Responses;
using EasyMicroservices.WhiteLabelsMicroservice.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.WhiteLabelsMicroservice.WebApi.Controllers
{
    public class ContextTableController : SimpleQueryServiceController<MicroserviceContextTableEntity, MicroserviceContextTableContract, MicroserviceContextTableContract, MicroserviceContextTableContract, MicroserviceContextTableContract>
    {
        public ContextTableController(IContractLogic<MicroserviceContextTableEntity, MicroserviceContextTableContract, MicroserviceContextTableContract, MicroserviceContextTableContract, MicroserviceContextTableContract> contractReadable) : base(contractReadable)
        {

        }

        protected override Func<IQueryable<MicroserviceContextTableEntity>, IQueryable<MicroserviceContextTableEntity>> OnGetQuery()
        {
            return query => query
            .Include(e => e.Microservice)
            .Include(e => e.ContextTable);
        }

        protected override Func<IQueryable<MicroserviceContextTableEntity>, IQueryable<MicroserviceContextTableEntity>> OnGetAllQuery()
        {
            return OnGetQuery();
        }
    }
}