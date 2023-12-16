using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Lecture : Entity<int>
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
    }
}
