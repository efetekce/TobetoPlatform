﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Certificate :Entity<int>
    {
        public int ProfileId { get; set; }
        public string? CertificateName { get; set; }
    }
}