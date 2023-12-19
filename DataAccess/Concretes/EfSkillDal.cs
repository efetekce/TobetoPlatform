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
    public class EfSkillDal : EfRepositoryBase<Skill,int,TobetoContext>, ISkillDal
    {
        TobetoContext _tobetoContext;
        public EfSkillDal(TobetoContext context) : base(context)
        {
            _tobetoContext = context;
        }
    }
}
