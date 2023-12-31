﻿using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Business.Rules;
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
    public class OrganizationManager : IOrganizationService
    {
        IOrganizationDal _organizationDal;
        IMapper _mapper;
        OrganizationBusinessRules _organizationBusinessRules;

        public OrganizationManager(IOrganizationDal organizationDal, IMapper mapper, OrganizationBusinessRules organizationBusinessRules)
        {
            _organizationDal = organizationDal;
            _mapper = mapper;
            _organizationBusinessRules = organizationBusinessRules;
        }

        public async Task<CreatedOrganizationResponse> Add(CreateOrganizationRequest createOrganizationRequest)
        {
            await _organizationBusinessRules.OrganizationNameCantBeNull(createOrganizationRequest.Name);
            await _organizationBusinessRules.ContactNumberCantBeNull(createOrganizationRequest.ContactNumber);
            await _organizationBusinessRules.MustBeAddressDefined(createOrganizationRequest.AddressId);

            Organization organization = _mapper.Map<Organization>(createOrganizationRequest);
            var createdOrganization = await _organizationDal.AddAsync(organization);
            CreatedOrganizationResponse result = _mapper.Map<CreatedOrganizationResponse>(createdOrganization);
            return result;
        }

        public async Task<DeletedOrganizationResponse> Delete(DeleteOrganizationRequest deleteOrganizationRequest)
        {
            Organization organization = _mapper.Map<Organization>(deleteOrganizationRequest);
            var deletedOrganization = await _organizationDal.DeleteAsync(organization, false);
            DeletedOrganizationResponse result = _mapper.Map<DeletedOrganizationResponse>(deletedOrganization);
            return result;
        }

        public async Task<IPaginate<GetListOrganizationResponse>> GetListOrganization(PageRequest pageRequest)
        {
            var organization = await _organizationDal.GetListAsync(
                orderBy: o => o.OrderBy(o => o.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListOrganizationResponse>>(organization);
            return result;
        }

        public async Task<UpdatedOrganizationResponse> Update(UpdateOrganizationRequest updateOrganizationRequest)
        {
            await _organizationBusinessRules.OrganizationNameCantBeNull(updateOrganizationRequest.Name);
            await _organizationBusinessRules.ContactNumberCantBeNull(updateOrganizationRequest.ContactNumber);
            await _organizationBusinessRules.MustBeAddressDefined(updateOrganizationRequest.AddressId);

            Organization organization = _mapper.Map<Organization>(updateOrganizationRequest);
            var updatedOrganization = await _organizationDal.UpdateAsync(organization);
            UpdatedOrganizationResponse result = _mapper.Map<UpdatedOrganizationResponse>(updatedOrganization);
            return result;
        }
    }
}
