using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Language : Entity<int>
    {
        public int ProfileId { get; set; }
        public string? LanguageName { get; set; }
        public string? LanguageLevel { get; set; }


    }
}
