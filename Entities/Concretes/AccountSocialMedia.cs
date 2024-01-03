using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AccountSocialMedia : Entity<int>
    {
        public int AccountId { get; set; }
        public int SocialMediaId { get; set; }
        public int Priority { get; set; }
        public string Link { get; set; }
        public Account Account { get; set; }
        public virtual ICollection<SocialMediaPlatform> SocialMediaPlatforms { get; set; }
    }
}
