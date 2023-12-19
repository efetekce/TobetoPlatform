using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AccountPassword : Entity<int>
    {
        public int AccountId { get; set; }
        public int Priority { get; set; }
        //public int MyProperty { get; set; }
        // sifre degistirme alani
    }
}
