﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request
{
    public class DeletedSocialMediaRequest
    {
        public int Id { get; set; }
        public string SocialMediaName { get; set; }
        public string Description { get; set; }
    }
}
