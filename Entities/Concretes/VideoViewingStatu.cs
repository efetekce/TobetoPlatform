using Core.Entities;

namespace Entities.Concretes
{
    public class VideoViewingStatu : Entity<int>
    {
        public int LessonId { get; set; }

        public string Name { get; set; }
    }
}
