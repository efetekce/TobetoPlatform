﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request
{
    public class CreateAccountPasswordRequest
    {
        public int AccountId { get; set; }
        public int Priority { get; set; }
    }
}
