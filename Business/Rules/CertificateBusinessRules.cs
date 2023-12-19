using Core.Business;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class CertificateBusinessRules : BaseBusinessRules
    {
        private readonly ICertificateDal _certificateDal;

        public CertificateBusinessRules(ICertificateDal certificateDal)
        {
          _certificateDal = certificateDal;
        }
        public async Task MaximumCertificateCountIsFive()
        {
            var result = await _certificateDal.GetListAsync();
            if (result.Count >= 5)
            {
                throw new Exception("Sertifikalar maximum 5 adet olabilir");
            }
        }

    }
}
