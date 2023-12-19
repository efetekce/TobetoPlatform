using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request
{

    public class CourseTitle : Entity<int>
    {
        public string Name { get; set; }

    }
}