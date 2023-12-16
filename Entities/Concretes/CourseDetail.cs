using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class CourseDetail : Entity<int>
    {
        public string CoverPath { get; set; }
        public string Name { get; set; }
        public bool IsFavorite { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime PublishedDate { get; set; }
        public int ProgressPercentage { get; set; }
    }
}
