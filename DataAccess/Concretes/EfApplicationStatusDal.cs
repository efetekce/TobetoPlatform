using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfApplicationStatusDal:EfRepositoryBase<ApplicationStatus,int,TobetoContext>,IApplicationStatusDal
    {
        public EfApplicationStatusDal(TobetoContext context):base(context)
        {
            TobetoContext _context;
        }
    }
}
