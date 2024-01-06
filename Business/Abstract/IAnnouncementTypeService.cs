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
    public interface IAnnouncementTypeService
    {
        Task<CreatedAnnouncementTypeResponse> Add(CreateAnnouncementTypeRequest createAnnouncementTypeRequest);
        Task<IPaginate<GetListAnnouncementTypeResponse>> GetListAnnouncementType(PageRequest pageRequest);
        Task<UpdatedAnnouncementTypeResponse> Update(UpdateAnnouncementTypeRequest updateAnnouncementTypeRequest);
        Task<DeletedAnnouncementTypeResponse> Delete(DeleteAnnouncementTypeRequest deleteAnnouncementTypeRequest);
    }
}
