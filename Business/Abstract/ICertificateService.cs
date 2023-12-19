﻿using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICertificateService 
    {
        Task<CreatedCertificateResponse> Add(CreateCertitificateRequest createCertitificateRequest);
        Task<IPaginate<GetListCertificateResponse>> GetListLanguage();
        Task<IPaginate<GetListCertificateResponse>> GetListCertificate();
        Task<UpdatedCertificateResponse> Update(UpdateCertitificateRequest updateCertitificateRequest);
        Task<DeletedCertificateResponse> Delete(DeleteCertitificateRequest deleteCertitificateRequest);
    }
}
