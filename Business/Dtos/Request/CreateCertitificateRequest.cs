using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request
{
    public class CreateCertitificateRequest
    {
      
        public int ProfileId { get; set; }
        public string? CertificateName { get; set; }

    }
}
