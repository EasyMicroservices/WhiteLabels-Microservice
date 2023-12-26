using System;

namespace EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common
{
    public class WhiteLabelContract
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long? ParentId { get; set; }
        public Guid? Key { get; set; }
    }
}
