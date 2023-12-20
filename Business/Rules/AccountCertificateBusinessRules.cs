using Business.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class AccountCertificateBusinessRules : BaseBusinessRules
    {
        private readonly IAccountCertificateDal _accountCertificateDal;
        public AccountCertificateBusinessRules(IAccountCertificateDal accountCertificateDal)
        {
            _accountCertificateDal = accountCertificateDal;
        }
        public async Task JustRequiredFileFormats(string extension)
        {
            string[] fileFormatArr = { ".jpeg", ".png", ".pdf" };
            if (!fileFormatArr.Contains(extension))
            {
                throw new BusinessException(BusinessMessages.FileFormatControl);
            }
        }

        public async Task MustBeUserDefined(int accountId)
        {
            var result = await _accountCertificateDal.GetListAsync(
                predicate: p => p.AccountId == accountId
                );
            if (result.Count == 0)
            {
                throw new BusinessException(BusinessMessages.AccountControl);
            }
        }
    }
}
