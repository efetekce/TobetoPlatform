﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request
{
    public class CreateCourseContentRequest
    {
        public int CourseId { get; set; }
        public int CourseContentTypeId { get; set; }
        public string Name { get; set; }
    }

}
