namespace EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common
{
    public class MicroserviceContract
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int InstanceIndex { get; set; }
        public string ServerDestinationAddress { get; set; }
    }
}
