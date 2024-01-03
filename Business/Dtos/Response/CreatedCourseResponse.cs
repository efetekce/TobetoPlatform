﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response
{
    public class CreatedCourseResponse
    {
        public int Id { get; set; }
        public int CourseContentId { get; set; }
        public int CourseAboutId { get; set; }
        public int LessonId { get; set; }
        public string ImageId { get; set; }
        public string Name { get; set; }
    }
}
