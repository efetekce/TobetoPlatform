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
    public class EfEducationDal : EfRepositoryBase<Education, int, TobetoContext>, IEducationDal
    {
        TobetoContext _tobetocontext;
        public EfEducationDal(TobetoContext context) : base(context)
        {
            _tobetocontext = context;
        }
    }
}
