﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response
{
    public class CreatedExperienceResponse
    {
        public int Id { get; set; }

        public int ProfileId { get; set; }

        public string CompanyName { get; set; }

        public string Position { get; set; }

        public string Field { get; set; }

        public int CityId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string JobDescription { get; set; }
    }
}
