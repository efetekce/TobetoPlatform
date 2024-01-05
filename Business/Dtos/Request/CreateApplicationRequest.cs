namespace Business.Dtos.Request
{
    public class CreateApplicationRequest
    {
        public int OrganizationId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
