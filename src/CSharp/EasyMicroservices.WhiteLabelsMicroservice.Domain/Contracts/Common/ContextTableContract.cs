namespace EasyMicroservices.WhiteLabelsMicroservice.Contracts.Common
{
    public class ContextTableContract
    {
        public long Id { get; set; }
        /// <summary>
        /// table name
        /// </summary>
        public string TableName { get; set; }
        /// <summary>
        /// database name
        /// </summary>
        public string ContextName { get; set; }
    }
}
