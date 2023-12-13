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
    public class EfAnnouncementDal : EfRepositoryBase<Announcement, int, TobetoContext>, IAnnouncementDal
    {
        TobetoContext _tobetoContext;
        public EfAnnouncementDal(TobetoContext context) : base(context)
        {
            _tobetoContext = context;
        }
    }
}
