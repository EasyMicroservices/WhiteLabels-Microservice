using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.WhiteLabelsMicroservice.Contracts.Responses;
using EasyMicroservices.WhiteLabelsMicroservice.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.WhiteLabelsMicroservice.WebApi.Controllers
{
    public class ContextTableController : SimpleQueryServiceController<ContextTableEntity, long, MicroserviceContextTableContract, MicroserviceContextTableContract, MicroserviceContextTableContract>
    {
        public ContextTableController(IContractLogic<ContextTableEntity, MicroserviceContextTableContract, MicroserviceContextTableContract, MicroserviceContextTableContract, long> contractReadable) : base(contractReadable)
        {

        }

        protected override Func<IQueryable<ContextTableEntity>, IQueryable<ContextTableEntity>> OnGetQuery()
        {
            return query => query
            .Include(e => e.MicroserviceContextTables).ThenInclude(e => e.Microservice);
        }

        protected override Func<IQueryable<ContextTableEntity>, IQueryable<ContextTableEntity>> OnGetAllQuery()
        {
            return OnGetQuery();
        }
    }
}