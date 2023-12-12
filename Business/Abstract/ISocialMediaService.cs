using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISocialMediaService
    {
        Task<CreatedSocialMediaResponse> Add(CreatedSocialMediaRequest createdSocialMediaRequest);
        Task<IPaginate<GetListSocialMediaResponse>> GetListSocialMedias();
        Task<UpdatedSocialMediaResponse> Update(UpdateSocialMediaRequest updateSocialMediaRequest);
        Task<DeletedSocialMediaResponse> Delete(DeletedSocialMediaRequest deleteSocialMediaRequest);
    }
}
