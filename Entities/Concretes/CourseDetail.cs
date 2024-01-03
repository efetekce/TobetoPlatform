using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class CourseDetail : Entity<int>
    {
        public int CourseId { get; set; }
       // public int CourseContentId { get; set; }
       public int LessonId { get; set; }
        public int CategoryId { get; set; }
        public int OrganizationId { get; set; }
        public string Language { get; set; }
        public string SubType { get; set; }

        public virtual Course Course { get; set; }
    //    public virtual Lesson Lesson { get; set; }
        public virtual CourseCategory CourseCategory { get; set; }
        public virtual Organization Organization { get; set; }

    }
}
