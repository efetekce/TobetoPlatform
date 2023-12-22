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
    public class CertificateManager : ICertificateService
    {
        ICertificateDal _certificateDal;
        IMapper _mapper;
        public CertificateManager(ICertificateDal certificateDal,IMapper mapper)
        {
            _certificateDal = certificateDal;
            _mapper = mapper;   
        }
        public async Task<CreatedCertificateResponse> Add(CreateCertitificateRequest createCertitificateRequest)
        {
            Certificate certificate = _mapper.Map<Certificate>(createCertitificateRequest);
            var createdCertificate = await _certificateDal.AddAsync(certificate);
            CreatedCertificateResponse result = _mapper.Map<CreatedCertificateResponse>(createdCertificate);
            return result;
        }

        public async Task<DeletedCertificateResponse> Delete(DeleteCertitificateRequest deleteCertitificateRequest)
        {
            Certificate certificate = _mapper.Map<Certificate>(deleteCertitificateRequest);
            var deletedCertificate = await _certificateDal.DeleteAsync(certificate);
            DeletedCertificateResponse result = _mapper.Map<DeletedCertificateResponse>(deletedCertificate);
            return result;
        }

        public async Task<IPaginate<GetListCertificateResponse>> GetListCertificate(){
            var certificate = await _certificateDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListCertificateResponse>>(certificate);
            return result;
        }

        public async Task<UpdatedCertificateResponse> Update(UpdateCertitificateRequest updateCertitificateRequest)
        {
            Certificate certificate = _mapper.Map<Certificate>(updateCertitificateRequest);
            var deletedCertificate = await _certificateDal.UpdateAsync(certificate);
            UpdatedCertificateResponse result = _mapper.Map<UpdatedCertificateResponse>(deletedCertificate);
            return result;
        }
    }
}
