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
    public interface IAccountCertificateService 
    {
        Task<CreatedAccountCertificateResponse> Add(CreateAccountCertificateRequest createCertificateRequest);
        Task<IPaginate<GetListAccountCertificateResponse>> GetListCertificate(PageRequest pageRequest);
        Task<UpdatedAccountCertificateResponse> Update(UpdateAccountCertificateRequest updateCertificateRequest);
        Task<DeletedAccountCertificateResponse> Delete(DeleteAccountCertificateRequest deleteCertificateRequest);
    }
}
