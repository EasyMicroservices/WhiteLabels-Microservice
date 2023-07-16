using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.CommentsMicroservice.Contracts.Common;
using EasyMicroservices.CommentsMicroservice.Database.Entities;

namespace EasyMicroservices.CommentsMicroservice.WebApi.Controllers
{
    public class CommentController : SimpleQueryServiceController<CommentEntity, CommentContract, CommentContract, CommentContract, long>
    {
        public CommentController(IContractLogic<CommentEntity, CommentContract, CommentContract, CommentContract, long> contractReadable) : base(contractReadable)
        {

        }
    }
}
