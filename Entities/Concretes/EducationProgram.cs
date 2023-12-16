using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class EducationProgram : Entity<int>
    {
        public int UniversityId { get; set; }
        public string Name { get; set; }
        public bool Visibility { get; set; }
    }
}
