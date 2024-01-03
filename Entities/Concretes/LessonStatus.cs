using Core.Entities;

namespace Entities.Concretes
{
    public class LessonStatus : Entity<int>
    {
        public int LessonId { get; set; }
        public string Name { get; set; }
        public virtual Lesson Lesson { get; set; }
    }
}
