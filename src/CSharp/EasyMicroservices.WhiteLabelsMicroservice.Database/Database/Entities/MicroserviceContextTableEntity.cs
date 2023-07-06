using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.WhiteLabelsMicroservice.Database.Entities
{
    public class MicroserviceContextTableEntity
    {
        public long ContextTableId { get; set; }
        public ContextTableEntity ContextTable { get; set; }
        public long MicroserviceId { get; set; }
        public MicroserviceEntity Microservice { get; set; }
    }
}
