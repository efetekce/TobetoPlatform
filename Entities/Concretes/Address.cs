using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Address : Entity<int>
    {
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string Detail { get; set; }

    }
}
