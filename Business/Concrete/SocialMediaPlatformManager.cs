using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concrete
{
    public class SocialMediaPlatformManager : ISocialMediaPlatformService
    {
        ISocialMediaPlatformDal _socialMediaPlatformDal;
        IMapper _mapper;
        //SocialMediaPlatformBusinessRules _socialMediaPlatformBusinessRules;

        public SocialMediaPlatformManager(ISocialMediaPlatformDal socialMediaPlatformDal,
        IMapper mapper)
        {
            _socialMediaPlatformDal = socialMediaPlatformDal;
            _mapper = mapper;
            //_socialMediaPlatformBusinessRules = socialMediaPlatformBusinessRules;
        }

        public async Task<CreatedSocialMediaPlatformResponse> Add(CreateSocialMediaPlatformRequest createSocialMediaPlatformRequest)
        {
            SocialMediaPlatform socialMediaPlatform = _mapper.Map<SocialMediaPlatform>(createSocialMediaPlatformRequest);
            var createdSocialMediaPlatform = await _socialMediaPlatformDal.AddAsync(socialMediaPlatform);
            CreatedSocialMediaPlatformResponse result = _mapper.Map<CreatedSocialMediaPlatformResponse>(createdSocialMediaPlatform);
            return result;
        }

        public async Task<DeletedSocialMediaPlatformResponse> Delete(DeleteSocialMediaPlatformRequest deleteSocialMediaPlatformRequest)
        {
            SocialMediaPlatform socialMediaPlatform = _mapper.Map<SocialMediaPlatform>(deleteSocialMediaPlatformRequest);
            var deletedSocialMediaPlatform = await _socialMediaPlatformDal.DeleteAsync(socialMediaPlatform);
            DeletedSocialMediaPlatformResponse result = _mapper.Map<DeletedSocialMediaPlatformResponse>(deletedSocialMediaPlatform);
            return result;
        }

        public async Task<IPaginate<GetListSocialMediaPlatformResponse>> GetListSocialMediaPlatform()
        {
            var socialMediaPlatform = await _socialMediaPlatformDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListSocialMediaPlatformResponse>>(socialMediaPlatform);
            return result;
        }

        public async Task<UpdatedSocialMediaPlatformResponse> Update(UpdateSocialMediaPlatformRequest updateSocialMediaPlatformRequest)
        {
            SocialMediaPlatform socialMediaPlatform = _mapper.Map<SocialMediaPlatform>(updateSocialMediaPlatformRequest);
            var updatedSocialMediaPlatform = await _socialMediaPlatformDal.UpdateAsync(socialMediaPlatform);
            UpdatedSocialMediaPlatformResponse result = _mapper.Map<UpdatedSocialMediaPlatformResponse>(updatedSocialMediaPlatform);
            return result;
        }
    }
}
