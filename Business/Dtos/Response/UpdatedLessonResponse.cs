namespace Business.Dtos.Response
{
    public class UpdatedLessonResponse
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int CourseContentId { get; set; }
        public string Name { get; set; }
        public int VideoDuration { get; set; }
    }
}
