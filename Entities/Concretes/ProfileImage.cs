using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class ProfileImage :Entity<int>
    {
        public Guid ProfileId { get; set; }
        public string ImagePath { get; set; }
    }
}
