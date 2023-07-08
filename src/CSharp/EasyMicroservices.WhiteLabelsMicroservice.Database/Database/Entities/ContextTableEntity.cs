using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.WhiteLabelsMicroservice.Database.Schemas;
using System.Collections;
using System.Collections.Generic;

namespace EasyMicroservices.WhiteLabelsMicroservice.Database.Entities
{
    public class ContextTableEntity : ContextTableSchema, IIdSchema<long>
    {
        public long Id { get; set; }

        public ICollection<MicroserviceContextTableEntity> MicroserviceContextTables { get; set; }
    }
}
