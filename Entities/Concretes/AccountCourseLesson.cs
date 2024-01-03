using Core.Entities;

namespace Entities.Concretes
{
    public class AccountCourseLesson:Entity<int>
    {
        public int AccountId { get; set; }
        public int LessonId { get; set; }
        public int LessonStatusId { get; set; }
        public bool Liked { get; set; }
        public bool IsActive { get; set;}

        public virtual Account Account { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }    
        public virtual ICollection<LessonStatus> LessonStatuses { get; set; }

    }
}
