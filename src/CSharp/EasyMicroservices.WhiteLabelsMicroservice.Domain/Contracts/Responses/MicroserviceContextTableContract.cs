namespace EasyMicroservices.WhiteLabelsMicroservice.Contracts.Responses
{
    public class MicroserviceContextTableContract
    {
        public string MicroserviceName { get; set; }
        public long MicroserviceId { get; set; }

        public string ContextName { get; set; }
        public long ContextId { get; set; }

        public string TableName { get; set; }
        public long TableId { get; set; }
    }
}
