﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request
{
    public class CreateAccountRequest
    {
      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        
    }
}
