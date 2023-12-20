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
<<<<<<< Updated upstream:Entities/Concretes/Language.cs
        public int ProfileId { get; set; }
        public string? LanguageName { get; set; }
        public string? LanguageLevel { get; set; }


=======
        public string Name { get; set; }
        //public int Priority { get; set; }
        //public bool Visibility { get; set; }
>>>>>>> Stashed changes:Entities/Concretes/ForeignLanguage.cs
    }
}
