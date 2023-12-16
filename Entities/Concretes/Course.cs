﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Course : Entity<int>
    {

        public int CourseDetailId { get; set; }
        public string Name { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
