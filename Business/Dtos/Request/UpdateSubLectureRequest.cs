using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request
{
    public class UpdateSubLectureRequest
    {
        public int Id { get; set; }
        public int LectureId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int Duration { get; set; }
    }
}
