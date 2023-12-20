namespace Business.Dtos.Request
{
    public class UpdateLessonRequest
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int CourseContentId { get; set; }
        public string Name { get; set; }
        public int VideoDuration { get; set; }
    }
}
