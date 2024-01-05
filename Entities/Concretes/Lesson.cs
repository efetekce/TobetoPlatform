using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Lesson : Entity<int>
    {
        public int CourseId { get; set; }
        public int CourseContentId { get; set; }
        public int CourseDetailId { get; set; }
        public string Name { get; set; }
        public int VideoDuration { get; set; }
        //public  CourseContent CourseContent { get; set; }
        //public Course Course { get; set; }
        //public virtual CourseDetail CourseDetail { get; set; }
    }
}
