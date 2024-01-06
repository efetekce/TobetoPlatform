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
    public class AccountTestResultMappingProfile:Profile
    {
        public AccountTestResultMappingProfile()
        {
            CreateMap<CreateAccountTestResultRequest, AccountTestResult>().ReverseMap();
            CreateMap<UpdateAccountTestResultRequest, AccountTestResult>().ReverseMap();
            CreateMap<DeleteAccountTestResultRequest, AccountTestResult>().ReverseMap();

            CreateMap<AccountTestResult, GetListAccountTestResultResponse>().ReverseMap();
            CreateMap<Paginate<AccountTestResult>, Paginate<GetListAccountTestResultResponse>>().ReverseMap();

            CreateMap<CreatedAccountTestResultResponse, AccountTestResult>().ReverseMap();
            CreateMap<UpdatedAccountTestResultResponse, AccountTestResult>().ReverseMap();
            CreateMap<DeletedAccountTestResultResponse, AccountTestResult>().ReverseMap();
        }
    }
}
