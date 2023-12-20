using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfPlatformCatalogDal : EfRepositoryBase<PlatformCatalog, int, TobetoContext>, IPlatformCatalogDal
    {
        TobetoContext _tobetoContext;
        public EfPlatformCatalogDal(TobetoContext context) : base(context)
        {
            _tobetoContext = context;
        }
    }
}
