using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request
{
    public class CreateAccountCourseRequest
    {
        public int AccountId { get; set; }
        public int CourseId { get; set; }
        public int PercentageOfCompletion { get; set; }
        //public DateTime ValidityDate { get; set; }
        public int Point { get; set; }
        public bool Like { get; set; }
        public bool Favorite { get; set; }
    }


}
