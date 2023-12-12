using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Skills : Entity<int>
    {
        public int ProfileId { get; set; }
        public string Skill { get; set; }
    }
}
