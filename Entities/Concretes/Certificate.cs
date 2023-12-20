﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Certificate : Entity<int>
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public int Priority { get; set; }
        public bool Visibility { get; set; }
    }
}
