using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Announcement : Entity<int>
    {
        public int ProfileId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime AnnouncementDate { get; set; }
    }
}
