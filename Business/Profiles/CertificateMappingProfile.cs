using AutoMapper;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CertificateMappingProfile :Profile
    {
        public CertificateMappingProfile()
        {
            CreateMap<CreateCertitificateRequest, Certificate>().ReverseMap();
            CreateMap<UpdateCertitificateRequest, Certificate>().ReverseMap();
            CreateMap<DeleteCertitificateRequest, Certificate>().ReverseMap();

            CreateMap<Certificate, GetListCertificateResponse>().ReverseMap();
            CreateMap<Paginate<Certificate>, Paginate<GetListCertificateResponse>>().ReverseMap();

            CreateMap<Certificate, CreatedCertificateResponse>().ReverseMap();
            CreateMap<Certificate, UpdatedCertificateResponse>().ReverseMap();
            CreateMap<Certificate, DeletedCertificateResponse>().ReverseMap();
        }
    }
}
