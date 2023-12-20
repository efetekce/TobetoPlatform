using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response
{
    public class CreatedLessonResponse
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int CourseContentId { get; set; }
        public string Name { get; set; }
        public int VideoDuration { get; set; }
    }
}
