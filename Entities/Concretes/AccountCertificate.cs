using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AccountCertificate : Entity<int>
    {

        public int AccountId { get; set; }
        public int CertificateId { get; set; }
        public int Priority { get; set; }

    }
}
