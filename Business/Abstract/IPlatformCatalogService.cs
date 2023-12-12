using Business.Dtos.Response;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPlatformCatalogService
    {
        Task<IPaginate<GetListPlatformCatalogResponse>> GetListPlatformCatalog();
    }
}
