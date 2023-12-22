using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request
{
    public class CreateAccountCourseLessonRequest
    {
        public int AccountId { get; set; }
        public int LessonId { get; set; }
        public int LessonStatusId { get; set; }
        public bool Like { get; set; }
        public bool IsActive { get; set; }
    }


}
