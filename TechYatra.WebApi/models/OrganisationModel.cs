namespace TechYatra.WebApi.models
{
    public class OrganisationModel
    {
        public int OrganisationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Purpose { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
