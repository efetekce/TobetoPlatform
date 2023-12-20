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
    public class CountryManager : ICountryService
    {
        ICountryDal _countryDal;
        IMapper _mapper;

        public CountryManager(ICountryDal countryDal, IMapper mapper)
        {
            _countryDal = countryDal;
            _mapper = mapper;
        }

        public async Task<CreatedCountryResponse> Add(CreateCountryRequest createCountryRequest)
        {
            Country country = _mapper.Map<Country>(createCountryRequest);
            var createdCountry = await _countryDal.AddAsync(country);
            CreatedCountryResponse result = _mapper.Map<CreatedCountryResponse>(createdCountry);
            return result;
        }

        public async Task<DeletedCountryResponse> Delete(DeleteCountryRequest deleteCountryRequest)
        {
            Country country = _mapper.Map<Country>(deleteCountryRequest);
            var deletedCountry = await _countryDal.DeleteAsync(country, true);
            DeletedCountryResponse result = _mapper.Map<DeletedCountryResponse>(deletedCountry);
            return result;
        }

        public async Task<IPaginate<GetListCountryResponse>> GetCountryListAsync()
        {
            var countries = await _countryDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListCountryResponse>>(countries);
            return result;

        }

        public async Task<UpdatedCountryResponse> Update(UpdateCountryRequest updateCountryRequest)
        {
            Country country = _mapper.Map<Country>(updateCountryRequest);
            var updatedCountry = await _countryDal.UpdateAsync(country);
            UpdatedCountryResponse result = _mapper.Map<UpdatedCountryResponse>(updatedCountry);
            return result;
        }
    }
}
