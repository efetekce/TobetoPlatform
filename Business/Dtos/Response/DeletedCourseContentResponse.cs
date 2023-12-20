namespace Business.Dtos.Response
{
    public class DeletedCourseContentResponse
    {
        public int Id { get; set; }
        public string CourseContentType { get; set; }
        public int CourseId { get; set; }
        public string Name { get; set; }
    }
}
