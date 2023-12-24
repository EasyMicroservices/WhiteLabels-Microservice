using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.Cores.Contracts.Requests;
using EasyMicroservices.Cores.Database.Managers;
using EasyMicroservices.ServiceContracts;
using EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common;
using EasyMicroservices.WhiteLabelsMicroservice.Database.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.WhiteLabelsMicroservice.WebApi.Controllers
{
    public class WhiteLabelController : SimpleQueryServiceController<WhiteLabelEntity, WhiteLabelContract, WhiteLabelContract, WhiteLabelContract, long>
    {
        public WhiteLabelController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        [HttpPost]
        public async Task<MessageContract<string>> GetUniqueIdentityByKey(GetByIdRequestContract<Guid> request)
        {
            var result = await UnitOfWork.GetLongReadableLogic<WhiteLabelEntity>()
                .GetBy(x => x.Key == request.Id
             , q => q.Include(x => x.Parent)
             .ThenInclude(x => x.Parent)
             .ThenInclude(x => x.Parent)
             .ThenInclude(x => x.Parent)
             .ThenInclude(x => x.Parent)
             .ThenInclude(x => x.Parent)
             ).AsCheckedResult();

            var parent = result;
            List<long> ids = new List<long>();
            do
            {
                ids.Add(parent.Id);
                parent = parent.Parent;
            }
            while (parent != null);
            ids.Reverse();
            return DefaultUniqueIdentityManager.GenerateUniqueIdentity(ids.ToArray());
        }
    }
}