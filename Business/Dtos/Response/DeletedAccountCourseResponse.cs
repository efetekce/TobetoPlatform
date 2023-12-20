namespace Business.Dtos.Response
{
    public class DeletedAccountCourseResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int CourseId { get; set; }
        public int PercentageofCompletion { get; set; }
        public DateTime ValidityDate { get; set; }
        public int Point { get; set; }
        public bool Like { get; set; }
    }
}
