namespace Business.Dtos.Request
{
    public class UpdateApplicationRequest
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
