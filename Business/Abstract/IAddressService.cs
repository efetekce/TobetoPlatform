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
    public interface IAddressService
    {
        Task<CreatedAddressResponse> Add(CreateAddressRequest createAddressRequest);

        Task<IPaginate<GetListAddressResponse>> GetAddressListAsync();

        Task<UpdatedAddressResponse> Update(UpdateAddressRequest updateAddressRequest);

        Task<DeletedAddressResponse> Delete(DeleteAddressRequest deleteAddressRequest);
    }
}
