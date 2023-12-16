using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AccountTestResult : Entity<int>
    {
        public int AccountId { get; set; }
        public int TestId { get; set; }

        public bool Visibility { get; set; }

        public int TotalCorrectAnswer { get; set; }
        public int TotalWrongAnswer { get; set; }
        public int TotalBlankAnswer { get; set; }
        public int Points { get; set; }
        //public bool IsCorrect { get; set; }
    }
}
