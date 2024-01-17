using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class CourseDetail : Entity<int>
    {
        public int CourseId { get; set; }
        public int CourseContentId { get; set; }
        public int CategoryId { get; set; }
        public int OrganizationId { get; set; }
        public int ForeignLanguageId { get; set; }
        public string SubType { get; set; }

        //Navigation Properties
        public virtual Course Course { get; set; }
        public virtual ICollection<CourseContent> CourseContents { get; set; }
        public virtual CourseCategory CourseCategory { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual ForeignLanguage ForeignLanguage { get; set; }

    }
}
