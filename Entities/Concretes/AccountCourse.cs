using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AccountCourse
    {
        public int AccountId { get; set; }
        public int CourseId { get; set; }
        public int ProgressPercentage { get; set; }
        public int MyProperty { get; set; }
    }
}
