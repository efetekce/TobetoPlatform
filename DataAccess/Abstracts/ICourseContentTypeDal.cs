using Business.Dtos.Request;
using Core.DataAccess.Repositories;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICourseContentTypeDal: IRepository<CourseContentType, int>, IAsyncRepository<CourseContentType, int>
    {
    }
}
