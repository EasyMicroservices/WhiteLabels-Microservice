using System;

namespace EasyMicroservices.WhiteLabelsMicroservice.Database.Schemas
{
    public class WhiteLabelSchema
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? Key { get; set; }
    }
}
