using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Organization:Entity<int>
    {
        public int AddressId { get; set; }
        public int Priority { get; set; }
        public bool Visibility { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public Address Address { get; set; }
        public ICollection<Survey> Surveys { get; set; }
    }
}
