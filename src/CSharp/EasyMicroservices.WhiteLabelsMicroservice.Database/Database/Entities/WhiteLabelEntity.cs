using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.WhiteLabelsMicroservice.Database.Schemas;
using System;
using System.Collections.Generic;

namespace EasyMicroservices.WhiteLabelsMicroservice.Database.Entities
{
    public class WhiteLabelEntity : WhiteLabelSchema, IIdSchema<long>
    {
        public long Id { get; set; }

        public Guid? Key { get; set; }
        public long? ParentId { get; set; }
        public WhiteLabelEntity Parent { get; set; }
        public ICollection<WhiteLabelEntity> Children { get; set; }
    }
}
