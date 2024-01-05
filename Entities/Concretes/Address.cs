﻿using Core.Entities;
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
        //public Country Country { get; set; }
        //public City City { get; set; }
        //public District District { get; set; }
    }
}


