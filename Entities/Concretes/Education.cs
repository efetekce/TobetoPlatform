using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Education : Entity<int>
    {
        public int ProfileId { get; set; }

        public bool Status { get; set; }

        public string University { get; set; }

        public string Major { get; set; }

        public DateTime StartYear { get; set; }

        public DateTime EndYear { get; set; }

        public DateTime GraduationYear { get; set; }
    }
}
