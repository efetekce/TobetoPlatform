﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response
{
    public class CreatedLanguageResponse
    {
        public int Id { get; set; }
        public string LanguageName { get; set; }
        public int LanguageLevel { get; set; }
    }
}
