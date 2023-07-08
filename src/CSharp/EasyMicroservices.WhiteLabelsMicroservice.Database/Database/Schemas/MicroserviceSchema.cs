using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.WhiteLabelsMicroservice.Database.Schemas
{
    public class MicroserviceSchema
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int InstanceIndex { get; set; }
        public string ServerDestinationAddress { get; set; }
    }
}
