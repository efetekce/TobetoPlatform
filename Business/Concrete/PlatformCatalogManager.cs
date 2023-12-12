using AutoMapper;
using Business.Abstract;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PlatformCatalogManager : IPlatformCatalogService
    {
        IPlatformCatalogDal _platformCatalogDal;
        IMapper _mapper;
        public PlatformCatalogManager(IPlatformCatalogDal platformCatalogDal,IMapper mapper)
        {
            _platformCatalogDal = platformCatalogDal;
            _mapper = mapper;
        }

        public async Task<IPaginate<GetListPlatformCatalogResponse>> GetListPlatformCatalog()
        {
            var platformcatalogs = await _platformCatalogDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListPlatformCatalogResponse>>(platformcatalogs);
            return result;
        }
    }
}
