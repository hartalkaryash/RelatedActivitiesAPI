namespace RelatedActivitiesAPI.Models
{
    public class RelatedActivities
    {
        public List<Contract> Value { get; set; }
        public bool HasMoreResults { get; set; }
    }

    public class Contract
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public string Url { get; set; }
        public Dictionary<string, string> AdditionalProperties { get; set; }
    }

}
