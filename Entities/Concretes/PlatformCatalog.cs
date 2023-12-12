using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class PlatformCatalog :Entity<int>
    {
        public int ProfileId { get; set; }
        public int CourseContentId { get; set; }
        public string Category { get; set; }
        public string Training { get; set; }
        public string Grade { get; set; }
        public string Subject { get; set; }
        public string Language { get; set; }
        public string Instructor { get; set; }
        public string Status { get; set;}

    }
}
