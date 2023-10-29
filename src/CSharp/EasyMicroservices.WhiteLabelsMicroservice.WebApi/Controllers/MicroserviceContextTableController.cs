using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.WhiteLabelsMicroservice.Contracts.Responses;
using EasyMicroservices.WhiteLabelsMicroservice.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.WhiteLabelsMicroservice.WebApi.Controllers
{
    public class MicroserviceContextTableController : SimpleQueryServiceController<MicroserviceContextTableEntity, MicroserviceContextTableContract, MicroserviceContextTableContract, MicroserviceContextTableContract, MicroserviceContextTableContract>
    {
        public MicroserviceContextTableController(IUnitOfWork unitOfWork) : base(unitOfWork)
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