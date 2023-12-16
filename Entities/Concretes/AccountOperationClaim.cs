using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AccountOperationClaim : Entity<int>
    {
        public int AccountId { get; set; }
        public int OperationClaimId { get; set; }
        public bool IsActive { get; set; }
        public int Priority { get; set; }

    }
}
