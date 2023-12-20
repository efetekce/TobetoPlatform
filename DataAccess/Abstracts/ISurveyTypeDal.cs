using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface ISurveyTypeDal : IRepository<SurveyType, int>, IAsyncRepository<SurveyType, int>
    {

    }
}
