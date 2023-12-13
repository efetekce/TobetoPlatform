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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;
        IMapper _mapper;

        public SocialMediaManager(ISocialMediaDal socialMediaDal, IMapper mapper)
        {
            _socialMediaDal = socialMediaDal;
            _mapper = mapper;
        }

        public async Task<CreatedSocialMediaResponse> Add(CreateSocialMediaRequest createSocialMediaRequest)
        {
            var socialMedia = _mapper.Map<SocialMedia>(createSocialMediaRequest);
            var createdSocialMedia = await _socialMediaDal.AddAsync(socialMedia);
            var createdSocialMediaResponse = _mapper.Map<CreatedSocialMediaResponse>(createdSocialMedia);
            return createdSocialMediaResponse;
        }

        public async Task<DeletedSocialMediaResponse> Delete(DeleteSocialMediaRequest deleteSocialMediaRequest)
        {
            var socialMedia = _mapper.Map<SocialMedia>(deleteSocialMediaRequest);
            var deletedSocialMedia = await _socialMediaDal.DeleteAsync(socialMedia, true);
            var deletedSocialMediaResponse = _mapper.Map<DeletedSocialMediaResponse>(deletedSocialMedia);
            return deletedSocialMediaResponse;
        }

        public async Task<IPaginate<GetListSocialMediaResponse>> GetListSocialMedias()
        {
            var socialMedias = await _socialMediaDal.GetListAsync();
            var mapped = _mapper.Map<Paginate<GetListSocialMediaResponse>>(socialMedias);
            return mapped;
        }

        public async Task<UpdatedSocialMediaResponse> Update(UpdateSocialMediaRequest updateSocialMediaRequest)
        {
            var socialMedia = _mapper.Map<SocialMedia>(updateSocialMediaRequest);
            var updatedSocialMedia = await _socialMediaDal.UpdateAsync(socialMedia);
            var updatedSocialMediaResponse = _mapper.Map<UpdatedSocialMediaResponse>(updatedSocialMedia);
            return updatedSocialMediaResponse;
        }
    }
}
