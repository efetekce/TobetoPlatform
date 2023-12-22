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
    public interface IAnnouncementService
    {
        Task<CreatedAnnouncementResponse> Add(CreateAnnouncementRequest createAnnouncementRequest);
        Task<IPaginate<GetListAnnouncementResponse>> GetListAnnouncement();
        Task<UpdatedAnnouncementResponse> Update(UpdateAnnouncementRequest updateAnnouncementRequest);
        Task<DeletedAnnouncementResponse> Delete(DeleteAnnouncementRequest deleteAnnouncementRequest);
    }
}
