using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class CourseCategory:Entity<int>
    {
        public int Name { get; set; }
    }
}
