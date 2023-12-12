using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LanguageManager : ILanguageService
    {
        ILanguageDal _languageDal;
        public Task<CreatedLanguageResponse> Add(CreateLanguageRequest createLanguageRequest)
        {
            throw new NotImplementedException();
        }

        public Task<IPaginate<GetListLanguageResponse>> GetListLanguage()
        {
            throw new NotImplementedException();
        }
    }
}
