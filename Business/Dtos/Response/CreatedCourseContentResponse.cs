﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response
{
    public class CreatedCourseContentResponse
    {
        public int Id { get; set; }
        public string CourseContentType { get; set; }
        public int CourseId { get; set; }
        public string Name { get; set; }
    }
}
