using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class SubLecture : Entity<int>
    {
        public int LectureId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int Duration { get; set; }
        //public string Category { get; set; }
    }
}
