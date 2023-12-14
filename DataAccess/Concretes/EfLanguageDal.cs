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
    public class EfLanguageDal : EfRepositoryBase<Language, int, TobetoContext>, ILanguageDal
    {
        TobetoContext _tobetoContext;
        public EfLanguageDal(TobetoContext context) : base(context)
        {
            _tobetoContext = context;
        }
    }
}
