﻿using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class EfSkillsDal : EfRepositoryBase<Skills, int, TobetoContext>, ISkillsDal
{
    TobetoContext _tobetoContext;
    public EfSkillsDal(TobetoContext context) : base(context)
    {
        _tobetoContext = context;
    }
}

