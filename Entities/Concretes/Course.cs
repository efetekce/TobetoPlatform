using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Course : Entity<int>
    {
        public int CourseContentId { get; set; }
        public int CourseAboutId { get; set; }
        public int LessonId { get; set; }
        public string ImageId { get; set; }
        public string Name { get; set; }
        

        //Navigation Properties
        public CourseDetail CourseDetail { get; set; }
        public virtual ICollection<CourseContent> CourseContents { get; set; }
        public virtual ICollection<AccountCourse> AccountCourse { get; set; }
    }
}
