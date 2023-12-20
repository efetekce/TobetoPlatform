namespace Business.Dtos.Request
{
    public class CreateSurveyRequest
    {
        public int OrganizationId { get; set; }
        public int SurveyTypeId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Link { get; set; }
        public DateTime PublishedDate { get; set; }
        public int Priority { get; set; }
        public bool Visibility { get; set; }
    }
}
