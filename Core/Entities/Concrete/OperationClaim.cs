using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class OperationClaim : Entity<int>
    {
        public string Name { get; set; }
        public List<UserOperationClaim> UserOperationClaims { get; set; }
        public List<User> Users { get; set; }
    }
}
