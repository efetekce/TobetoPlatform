namespace Business.Dtos.Response
{
    public class GetListSurveyResponse
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int SurveyTypeId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Link { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
