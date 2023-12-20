using Core.DataAccess.Repositories;
using Core.Entities.Concrete;
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
    public class EfUserDal : EfRepositoryBase<User, int, TobetoContext>, IUserDal
    {
        public EfUserDal(TobetoContext context) : base(context)
        {
            TobetoContext _context;
        }


       
        List<Core.Entities.Concrete.OperationClaim> IUserDal.GetClaims(User user)
        {
            throw new NotImplementedException();
        }
    }
}
