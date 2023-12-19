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
    public class CityManager : ICityService
    {
        ICityDal _cityDal;
        IMapper _mapper;

        public CityManager(ICityDal cityDal, IMapper mapper)
        {
            _cityDal = cityDal;
            _mapper = mapper;
        }

        public async Task<CreatedCityResponse> Add(CreateCityRequest createCityRequest)
        {
            City city = _mapper.Map<City>(createCityRequest);
            var createdCity = await _cityDal.AddAsync(city);
            CreatedCityResponse result = _mapper.Map<CreatedCityResponse>(createdCity);
            return result;
        }

        public async Task<DeletedCityResponse> Delete(DeleteCityRequest deleteCityRequest)
        {
            City city = _mapper.Map<City>(deleteCityRequest);
            var deletedCity = await _cityDal.DeleteAsync(city, true);
            DeletedCityResponse result = _mapper.Map<DeletedCityResponse>(deletedCity);
            return result;
        }

        public async Task<IPaginate<GetListCityResponse>> GetCityListAsync(PageRequest pageRequest)
        {
            var addresss = await _cityDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListCityResponse>>(addresss);
            return result;
        }

        public async Task<UpdatedCityResponse> Update(UpdateCityRequest updateCityRequest)
        {
            City city = _mapper.Map<City>(updateCityRequest);
            var updatedCity = await _cityDal.UpdateAsync(city);
            UpdatedCityResponse result = _mapper.Map<UpdatedCityResponse>(updatedCity);
            return result;
        }
    }
}
