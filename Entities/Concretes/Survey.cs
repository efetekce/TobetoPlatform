using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Survey : Entity<int>
    {
        public int OrganizationId { get; set; }
        public int SurveyTypeId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Link { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
