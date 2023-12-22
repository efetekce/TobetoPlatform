using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;
        IMapper _mapper;

        public AnnouncementManager(IAnnouncementDal announcementDal, IMapper mapper)
        {
            _announcementDal = announcementDal;
            _mapper = mapper;
        }

        public async Task<CreatedAnnouncementResponse> Add(CreateAnnouncementRequest createAnnouncementRequest)
        {
            Announcement announcement = _mapper.Map<Announcement>(createAnnouncementRequest);
            var createdAnnouncement = await _announcementDal.AddAsync(announcement);
            CreatedAnnouncementResponse result = _mapper.Map<CreatedAnnouncementResponse>(createdAnnouncement);
            return result;
        }

        public async Task<DeletedAnnouncementResponse> Delete(DeleteAnnouncementRequest deleteAnnouncementRequest)
        {
            Announcement announcement = _mapper.Map<Announcement>(deleteAnnouncementRequest);
            var deletedAnnouncement = await _announcementDal.DeleteAsync(announcement, true);
            DeletedAnnouncementResponse result = _mapper.Map<DeletedAnnouncementResponse>(deletedAnnouncement);
            return result;
        }

        public async Task<IPaginate<GetListAnnouncementResponse>> GetListAnnouncement(PageRequest pageRequest)
        {
            var announcements = await _announcementDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListAnnouncementResponse>>(announcements);
            return result;
        }

        public async Task<UpdatedAnnouncementResponse> Update(UpdateAnnouncementRequest updateAnnouncementRequest)
        {
            Announcement announcement = _mapper.Map<Announcement>(updateAnnouncementRequest);
            var updatedAnnouncement = await _announcementDal.UpdateAsync(announcement);
            UpdatedAnnouncementResponse result = _mapper.Map<UpdatedAnnouncementResponse>(updatedAnnouncement);
            return result;
        }
    }
}
