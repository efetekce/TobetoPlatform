using Core.Entities;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request
{

    public class CourseContentType : Entity<int>
    {
        public string Name { get; set; }
        public virtual ICollection<CourseContent> CourseContents { get; set; }

    }
}