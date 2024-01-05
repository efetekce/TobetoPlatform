using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class CourseContent:Entity<int>
    {
        public int CourseId { get; set; }    
        public int ContentTypeId { get; set; }
        public string Name { get; set; }
        //public Course Course { get; set; }
        //public virtual ICollection<Lesson> Lessons { get; set; }
        //public virtual CourseContentType CourseContentType { get; set; }
    }
}

