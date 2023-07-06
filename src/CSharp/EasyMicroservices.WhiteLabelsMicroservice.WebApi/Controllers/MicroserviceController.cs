using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.WhiteLabelsMicroservice.Contracts.Responses;
using EasyMicroservices.WhiteLabelsMicroservice.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.WhiteLabelsMicroservice.WebApi.Controllers
{
    public class MicroserviceController : SimpleQueryServiceController<MicroserviceEntity, long, MicroserviceContextTableContract, MicroserviceContextTableContract, MicroserviceContextTableContract>
    {
        public MicroserviceController(IContractLogic<MicroserviceEntity, MicroserviceContextTableContract, MicroserviceContextTableContract, MicroserviceContextTableContract, long> contractReadable) : base(contractReadable)
        {

        }

        protected override Func<IQueryable<MicroserviceEntity>, IQueryable<MicroserviceEntity>> OnGetQuery()
        {
            return query => query
            .Include(e => e.MicroserviceContextTables).ThenInclude(x => x.ContextTable);
        }

        protected override Func<IQueryable<MicroserviceEntity>, IQueryable<MicroserviceEntity>> OnGetAllQuery()
        {
            return OnGetQuery();
        }
    }
}