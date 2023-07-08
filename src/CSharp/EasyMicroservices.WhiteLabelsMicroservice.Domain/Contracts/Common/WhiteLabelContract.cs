namespace EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common
{
    public class WhiteLabelContract
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? ParentId { get; set; }
    }
}
