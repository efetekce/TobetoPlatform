<<<<<<< Updated upstream
﻿using System;
=======
﻿using Core.DataAccess.Repositories;
using Core.Entities.Concrete;
using Entities.Concretes;
using System;
>>>>>>> Stashed changes
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
<<<<<<< Updated upstream
    public interface IUserDal
    {
=======
    public interface IUserDal: IRepository<User, int>, IAsyncRepository<User, int>
    {
        List<OperationClaim> GetClaims(User user);

>>>>>>> Stashed changes
    }
}
