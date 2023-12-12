using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILanguageService
    {
        Task<CreatedLanguageResponse> Add(CreateLanguageRequest createLanguageRequest);
        Task<IPaginate<GetListLanguageResponse>> GetListLanguage();
    }
}
