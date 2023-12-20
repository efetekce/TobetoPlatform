using Core.Entities;

namespace Entities.Concretes
{
    public class AccountCourseLesson:Entity<int>
    {
        public int AccountId { get; set; }
        public int LessonId { get; set; }
        public int VideoViewingStatusId { get; set; }
        public bool Like { get; set; }
        public bool IsActive { get; set;}
    }
}
