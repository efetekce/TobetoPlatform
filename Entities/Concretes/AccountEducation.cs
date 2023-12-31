﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AccountEducation:Entity<int>
    {
        public int AccountId { get; set; }
        public int EducationStatusId { get; set; }
        public int UniversityId { get; set; }
        public int EducationProgramId { get; set; }
        public bool Visibility { get; set; }
        public DateTime StartYear { get; set; }
        public DateTime GraduationYear { get; set; }
        public bool IsGraduated { get; set; }
        public virtual Account Account { get; set; }
        public virtual EducationStatus EducationStatus { get; set; }
        public virtual University University { get; set; }
        public virtual EducationProgram EducationProgram { get; set; }
    }
}
