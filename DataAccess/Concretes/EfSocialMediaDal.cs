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
    public class EfSocialMediaDal : EfRepositoryBase<SocialMedia, int, TobetoContext>, ISocialMediaDal
    {
        TobetoContext _tobetoContext;
        public EfSocialMediaDal(TobetoContext context) : base(context)
        {
            _tobetoContext = context;
        }
    }
}
