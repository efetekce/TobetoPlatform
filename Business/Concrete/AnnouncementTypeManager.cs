using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AnnouncementTypeManager : IAnnouncementTypeService
    {

        IAnnouncementTypeDal _announcementTypeDal;
        IMapper _mapper;

        public AnnouncementTypeManager(IAnnouncementTypeDal announcementTypeDal, IMapper mapper)
        {
            _announcementTypeDal = announcementTypeDal;
            _mapper = mapper;
        }

        public async Task<CreatedAnnouncementTypeResponse> Add(CreateAnnouncementTypeRequest createAnnouncementTypeRequest)
        {
            AnnouncementType announcementType = _mapper.Map<AnnouncementType>(createAnnouncementTypeRequest);
            var createdAnnouncementType = await _announcementTypeDal.AddAsync(announcementType);
            CreatedAnnouncementTypeResponse result = _mapper.Map<CreatedAnnouncementTypeResponse>(createdAnnouncementType);
            return result;
        }

        public async Task<DeletedAnnouncementTypeResponse> Delete(DeleteAnnouncementTypeRequest deleteAnnouncementTypeRequest)
        {
            AnnouncementType announcementType = _mapper.Map<AnnouncementType>(deleteAnnouncementTypeRequest);
            var deletedAnnouncementType = await _announcementTypeDal.DeleteAsync(announcementType, false);
            DeletedAnnouncementTypeResponse result = _mapper.Map<DeletedAnnouncementTypeResponse>(deletedAnnouncementType);
            return result;
        }

        public async Task<IPaginate<GetListAnnouncementTypeResponse>> GetListAnnouncementType(PageRequest pageRequest)
        {
            var announcementTypes = await _announcementTypeDal.GetListAsync(
                orderBy: a => a.OrderBy(a => a.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListAnnouncementTypeResponse>>(announcementTypes);
            return result;
        }

        public async Task<UpdatedAnnouncementTypeResponse> Update(UpdateAnnouncementTypeRequest updateAnnouncementTypeRequest)
        {
            AnnouncementType announcementType = _mapper.Map<AnnouncementType>(updateAnnouncementTypeRequest);
            var updatedAnnouncementType = await _announcementTypeDal.UpdateAsync(announcementType);
            UpdatedAnnouncementTypeResponse result = _mapper.Map<UpdatedAnnouncementTypeResponse>(updatedAnnouncementType);
            return result;
        }
    }
}
