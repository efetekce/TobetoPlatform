namespace Business.Dtos.Request
{
    public class UpdateAccountCourseLessonRequest
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int LessonId { get; set; }
        public int LessonStatusId { get; set; }
        public bool Like { get; set; }
        public bool IsActive { get; set; }
    }


}
