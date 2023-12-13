using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response
{
    public class CreatedEducationResponse
    {
        public int Id { get; set; }

        public int ProfileId { get; set; }

        public bool Status { get; set; }

        public string University { get; set; }

        public string Major { get; set; }

        public DateTime StartYear { get; set; }

        public DateTime EndYear { get; set; }

        public DateTime GraduationYear { get; set; }
    }
}
