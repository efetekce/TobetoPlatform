using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AccountForeignLanguage : Entity<int>
    {
        public int AccountId { get; set; }
        public int ForeignLanguageId { get; set; }
        public int ForeignLanguageLevelId { get; set; }
        //public virtual Account Account { get; set; }
        //public virtual ForeignLanguage ForeignLanguage { get; set; }
        //public virtual ForeignLanguageLevel ForeignLanguageLevel { get; set; }    
    }
}
