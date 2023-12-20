using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AccountCertificateManager : IAccountCertificateService
    {
        IAccountCertificateDal _certificateDal;
        IMapper _mapper;
        AccountCertificateBusinessRules _accountCertificateBusinessRules;
        public AccountCertificateManager(IAccountCertificateDal certificateDal,IMapper mapper, AccountCertificateBusinessRules accountCertificateBusinessRules)
        {
            _certificateDal = certificateDal;
            _mapper = mapper;
            _accountCertificateBusinessRules = accountCertificateBusinessRules;
        }
        public async Task<CreatedAccountCertificateResponse> Add(CreateAccountCertificateRequest createCertitificateRequest)
        {
            //string extension = System.IO.Path.GetExtension(file.FileName); 
            string fileName = @"" + createCertitificateRequest.Name + "";
            string extension = Path.GetExtension(fileName);

            //await _accountCertificateBusinessRules.MustBeUserDefined(createCertitificateRequest.AccountId);
            //await _accountCertificateBusinessRules.JustRequiredFileFormats(extension);

            string value = DecodeFunc(extension,
                new Dictionary<string, string>
                {
                    { ".pdf", "application/pdf" },
                    { ".jpeg", "image/jpeg" },
                    { ".png", "image/png" },
                }, "Diğer");

            

            //aşağıdaki kod nerede olmalı ?
            static TValue DecodeFunc<TKey, TValue>(TKey key, Dictionary<TKey, TValue> result, TValue defaultVal)
            {
                return result.TryGetValue(key, out var value) ? value : defaultVal;
            }

            AccountCertificate certificate = _mapper.Map<AccountCertificate>(createCertitificateRequest);
            certificate.FileFormat = value;
            var createdCertificate = await _certificateDal.AddAsync(certificate);
            CreatedAccountCertificateResponse result = _mapper.Map<CreatedAccountCertificateResponse>(createdCertificate);
            return result;
        }

        public async Task<DeletedAccountCertificateResponse> Delete(DeleteAccountCertificateRequest deleteCertitificateRequest)
        {
            AccountCertificate certificate = _mapper.Map<AccountCertificate>(deleteCertitificateRequest);
            var deletedCertificate = await _certificateDal.DeleteAsync(certificate);
            DeletedAccountCertificateResponse result = _mapper.Map<DeletedAccountCertificateResponse>(deletedCertificate);
            return result;
        }

        public async Task<IPaginate<GetListAccountCertificateResponse>> GetListCertificate(PageRequest pageRequest)
        {
            var certificate = await _certificateDal.GetListAsync(
                orderBy: c => c.OrderBy(c => c.Name).ThenByDescending(c => c.CreatedDate),
                index: pageRequest.PageIndex,
                size: 7 //tobetoda 7
            );
            var result = _mapper.Map<Paginate<GetListAccountCertificateResponse>>(certificate);
            return result;

            
        }

        public async Task<UpdatedAccountCertificateResponse> Update(UpdateAccountCertificateRequest updateCertitificateRequest)
        {
            //Burayı sor!
            string extension = Path.GetExtension(updateCertitificateRequest.Name);

            string value = DecodeFunc(extension,
                new Dictionary<string, string>
                {
                    { ".pdf", "application/pdf" },
                    { ".jpeg", "image/jpeg" },
                    { ".png", "image/png" },
                }, "Diğer");

            //aşağıdaki kod nerede olmalı ?
            static TValue DecodeFunc<TKey, TValue>(TKey key, Dictionary<TKey, TValue> result, TValue defaultVal)
            {
                return result.TryGetValue(key, out var value) ? value : defaultVal;
            }

            await _accountCertificateBusinessRules.MustBeUserDefined(updateCertitificateRequest.AccountId);
            await _accountCertificateBusinessRules.JustRequiredFileFormats(extension);
            AccountCertificate certificate = _mapper.Map<AccountCertificate>(updateCertitificateRequest);
            certificate.FileFormat = value;
            var updatedCertificate = await _certificateDal.UpdateAsync(certificate);
            UpdatedAccountCertificateResponse result = _mapper.Map<UpdatedAccountCertificateResponse>(updatedCertificate);
            return result;
        }
    }
}
