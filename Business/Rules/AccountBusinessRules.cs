using Business.Constants.Messages;
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
    public class AccountBusinessRules :BaseBusinessRules
    {
        private readonly IAccountDal _accountDal;

        public AccountBusinessRules(IAccountDal accountDal)
        {
            _accountDal = accountDal;
        }

        public async Task MaxNationalIdLength(string nationalId)
        {
            //Bu kısımda henüz tc kimlik kaydı olmadı
            //var result = await _accountDal.GetListAsync(a => a.NationalId == nationalId);
            if (nationalId.ToString().Length != 11) 
            {
                throw new BusinessException("tc 11 hanelı olmalı ");
            }
        }

        //NationalId nin unique olması durumu ayrı iş kuralı olmalı
        public async Task NationalIdMustBeUnique(string nationalId)
        {
            var result = await _accountDal.GetListAsync(a => a.NationalId == nationalId);
            if (result.Count > 0)
            {
                throw new BusinessException("Geçerli bir kimlik idsi giriniz");
            }
        }
    }
}
