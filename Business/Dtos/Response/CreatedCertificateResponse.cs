using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response
{
    public class CreatedCertificateResponse
    {
        public int Id {  get; set; }
        public int ProfileId { get; set; }
        public string? CertificateName { get; set; }
    }
}
