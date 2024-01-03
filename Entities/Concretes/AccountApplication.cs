using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AccountApplication : Entity<int>
    {
        public int AccountId { get; set; }
        public int ApplicationId { get; set; }
        public int ApplicationStepId { get; set; }
        public virtual Account Account { get; set; }
        public virtual Application Application { get; set; }    
        public virtual ApplicationStep ApplicationStep { get; set; }
    }
}
