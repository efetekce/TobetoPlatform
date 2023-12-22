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
    public class DistrictManager : IDistrictService
    {
        IDistrictDal _districtDal;
        IMapper _mapper;

        public DistrictManager(IDistrictDal districtDal, IMapper mapper)
        {
            _districtDal = districtDal;
            _mapper = mapper;
        }

        public async Task<CreatedDistrictResponse> Add(CreateDistrictRequest createDistrictRequest)
        {
            District district = _mapper.Map<District>(createDistrictRequest);
            var createdDistrict = await _districtDal.AddAsync(district);
            CreatedDistrictResponse result = _mapper.Map<CreatedDistrictResponse>(createdDistrict);
            return result;
        }

        public async Task<DeletedDistrictResponse> Delete(DeleteDistrictRequest deleteDistrictRequest)
        {
            District district = _mapper.Map<District>(deleteDistrictRequest);
            var deletedDistrict = await _districtDal.DeleteAsync(district, true);
            DeletedDistrictResponse result = _mapper.Map<DeletedDistrictResponse>(deletedDistrict);
            return result;
        }

        public async Task<IPaginate<GetListDistrictResponse>> GetDistrictListAsync(PageRequest pageRequest)
        {
            var districts = await _districtDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListDistrictResponse>>(districts);
            return result;
        }

        public async Task<UpdatedDistrictResponse> Update(UpdateDistrictRequest updateDistrictRequest)
        {
            District district = _mapper.Map<District>(updateDistrictRequest);
            var updatedDistrict = await _districtDal.UpdateAsync(district);
            UpdatedDistrictResponse result = _mapper.Map<UpdatedDistrictResponse>(updatedDistrict);
            return result;
        }
    }
}
