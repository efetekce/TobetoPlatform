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
        public int CourseContentTypeId { get; set; }
        public string Name { get; set; }
    }
}
