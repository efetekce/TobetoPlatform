using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AccountCourse:Entity<int>
    {
        public int AccountId { get; set; }
        public int CourseId { get; set; }
        public virtual Account Account { get; set; }
        public ICollection<Course> Course { get; set; }
        public int PercentageOfCompletion { get; set; }
        public int Point { get; set; }
        public bool Like { get; set; }
        public bool Favorite { get; set; }
        
    }
}
