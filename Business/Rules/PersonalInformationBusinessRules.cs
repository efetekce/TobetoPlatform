using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class PersonalInformationBusinessRules :BaseBusinessRules
    {
        //private readonly IPersonalInformationDal _personalInformationDal;

        //public PersonalInformationBusinessRules(IPersonalInformationDal personalInformationDal)
        //{
        //    _personalInformationDal = personalInformationDal;
        //}
        //public async Task MaximumCategoryCountIsTen()
        //{
        //    var result = await _personalInformationDal.GetAsync;
        //    if (result.Count >= 10) { throw new Exception("Kategori sayısı max 10 olabilir"); }
        //}
    }
}
