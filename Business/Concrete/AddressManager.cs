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
    public class AddressManager : IAddressService
    {
        IAddressDal _addressDal;
        IMapper _mapper;

        public AddressManager(IAddressDal addressDal, IMapper mapper)
        {
            _addressDal = addressDal;
            _mapper = mapper;
        }

        public async Task<CreatedAddressResponse> Add(CreateAddressRequest createAddressRequest)
        {
            Address address = _mapper.Map<Address>(createAddressRequest);
            var createdAddress = await _addressDal.AddAsync(address);
            CreatedAddressResponse result = _mapper.Map<CreatedAddressResponse>(createdAddress);
            return result;
        }

        public async Task<DeletedAddressResponse> Delete(DeleteAddressRequest deleteAddressRequest)
        {
            Address address = _mapper.Map<Address>(deleteAddressRequest);
            var deletedAddress = await _addressDal.DeleteAsync(address, false);
            DeletedAddressResponse result = _mapper.Map<DeletedAddressResponse>(deletedAddress);
            return result;
        }

        public async Task<IPaginate<GetListAddressResponse>> GetAddressListAsync(PageRequest pageRequest)
        {
            var addresses = await _addressDal.GetListAsync(
                orderBy: a => a.OrderBy(a => a.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListAddressResponse>>(addresses);
            return result;
        }

        public async Task<UpdatedAddressResponse> Update(UpdateAddressRequest updateAddressRequest)
        {
            Address address = _mapper.Map<Address>(updateAddressRequest);
            var updatedAddress = await _addressDal.UpdateAsync(address);
            UpdatedAddressResponse result = _mapper.Map<UpdatedAddressResponse>(updatedAddress);
            return result;
        }
    }
}
